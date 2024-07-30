COMMAND="godot --headless --export-release Linux output"

echo "# Exporting with $COMMAND"

$COMMAND

echo
echo "# godot exited with exit code: $?"
