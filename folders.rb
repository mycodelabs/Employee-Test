#!/usr/bin/env ruby
require './unique_files.rb'
root_folder = File.expand_path(File.dirname(__FILE__))
framework_location = "C:/Windows/Microsoft.NET/Framework64/"

Folders = {
	:root => root_folder,
	:outputdir => File.join(root_folder, "artifacts"),
	:solution_folder => File.join(root_folder, "solution"),
}

Projects = [
		"domain",
		"infrastructure",
		"controllers",
		"tasks"
	   ]

Files = {
	:output => File.join(Folders[:outputdir], "Employee_test.dll")
}

Package = {
	:package_folder => File.join(Folders[:solution_folder], "packages")
}

Framework = {
	:version => File.join(framework_location, "v4.0.30319"),
}

Compiler = {
	:location => File.join(Framework[:version], "csc.exe")
}

References = {
	:all => UniqueFiles.new(Dir.glob("referenced_assemblies/**/*.{dll,exe}")).all_files, 
}
