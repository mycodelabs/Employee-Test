#!/usr/bin/env ruby
require "albacore"
require './folders.rb'
require './setup.rb'

task :default => [:setup,:compile]
csc :compile do |csc|
	Projects.each do |project|
		csc.command = Compiler[:location] 
		csc.compile FileList["#{project}/*.cs"]
		csc.output = Files[:output] 
		csc.target = :library
	end
end
