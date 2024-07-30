using Godot;
using System;

public partial class Node2d : Node2D
{
	public override void _Ready()
	{
		// Here's a syntax error so that the build fails
		hello shift and numbers !@#$%^&*()
	}

	public override void _Process(double delta)
	{
	}
}
