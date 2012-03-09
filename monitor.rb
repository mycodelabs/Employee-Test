class Monitor

def get_errors_in(output)
  error_pattern = /error|FAIL/
  output.split("\n").select{|item| error_pattern =~ item}
end

def notify(build_message)
  icon = build_message.successful ? "green" : "red"
  args = {:t => "compile",:i => ".\\#{icon}.jpg"}
  command_line = "build/tools/growl/growlnotify.exe"
  args.each {|key,value| command_line += " /#{key}:\"#{value}\""}
  `#{command_line} "#{build_message.message}"`
end

def monitor_changes
    errors = get_errors_in(`rake`)
    notify(BuildMessage.new(errors))
end
end

class BuildMessage
  def initialize(error_items)
    @error_items = error_items
  end

  def successful
    @error_items.length == 0
  end

  def message
    successful ? "Build Successful" : @error_items.join("\r\n")
  end
end
