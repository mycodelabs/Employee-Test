require "rubygems"
task :setup do
	FileUtils.mkdir Folders[:outputdir] unless File.exist? Folders[:outputdir]
	FileUtils.rm_f("#{Folders[:outputdir]}/**/*")
	copy_referenced_assemblies()
end

def copy_referenced_assemblies()
	dir = Package[:package_folder] 
	puts dir
	$LOAD_PATH.unshift(dir)
	FileUtils.cp(Dir[File.join(dir, "/**/lib/*.dll")], Folders[:outputdir])
end

