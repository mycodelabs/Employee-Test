#!/usr/bin/env ruby
require "albacore"
require './folders.rb'
require './setup.rb'

task :default => [:setup,:compile]
csc :compile do |csc|
	Projects.each do |project|
		csc.command = Compiler[:location] 
		csc.compile FileList[File.join(Folders[:root],"#{project}/*.cs")]
		csc.output = File.join(Folders[:outputdir], "#{project}.dll") 
		csc.target = :library
		csc.references = References[:all] 
	end
end
