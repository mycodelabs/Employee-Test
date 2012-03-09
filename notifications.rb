#!/usr/bin/env ruby
require "rb-fchange"
require "./folders.rb"

notifier = FChange::Notifier.new
  notifier.watch(Folders[:root], :all_events, :recursive) do |event|
    monitor = Monitor.new
    monitor.monitor_changes
  end

  Signal.trap('INT') do
    p "Bye bye...",
    notifier.stop
    abort("\n")
  end

notifier.run


class Monitor

def get_errors_in(output)
  error_pattern = /error|FAIL/
  output.split("\n").select{|item| error_pattern =~ item}
end

def notify(build_message)
  icon = build_message.successful ? "green" : "red"
  args = {:t => "Build",:i => ".\\#{icon}.jpg"}
  command_line = "build/tools/growl/growlnotify.exe"
  args.each {|key,value| command_line += " /#{key}:\"#{value}\""}
  `#{command_line} "#{build_message.message}"`
end

def monitor_chanages
    errors = get_errors_in(`rake`)
    notify(BuildMessage.new(errors))
end

end
