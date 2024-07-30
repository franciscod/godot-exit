# godot-exit

Minimal Reproduction Project for https://github.com/godotengine/godot/issues/94957



        $ ./run_export.sh
        # Exporting with godot --headless --export-release Linux output
        Godot Engine v4.3.dev6.mono.official.64520fe67 - https://godotengine.org

        dotnet_publish_project: begin: Publishing .NET project... steps: 1
                dotnet_publish_project: step 0: Running dotnet publish
        dotnet_publish_project: end
        ERROR: Failed to export project: Failed to build project.
           at: void GodotTools.Export.ExportPlugin._ExportBegin(System.String[], bool, string, uint) (/root/godot/modules/mono/editor/GodotTools/GodotTools/Export/ExportPlugin.cs:123)
        System.InvalidOperationException: Failed to build project.
           at GodotTools.Export.ExportPlugin._ExportBeginImpl(String[] features, Boolean isDebug, String path, Int64 flags) in /root/godot/modules/mono/editor/GodotTools/GodotTools/Export/ExportPlugin.cs:line 255
           at GodotTools.Export.ExportPlugin._ExportBegin(String[] features, Boolean isDebug, String path, UInt32 flags) in /root/godot/modules/mono/editor/GodotTools/GodotTools/Export/ExportPlugin.cs:line 123
        savepack: begin: Packing steps: 102
                savepack: step 2: Storing File: res://.godot/imported/icon.svg-218a8f2b3041327d8a5756f3a245f83b.ctex
                savepack: step 2: Storing File: res://icon.svg.import
                savepack: step 35: Storing File: res://Node2d.cs
                savepack: step 68: Storing File: res://.godot/exported/133200997/export-362256a061aa8890e9a1e558b11e5ec3-node_2d.scn
                savepack: step 102: Storing File: res://node_2d.tscn.remap
                savepack: step 102: Storing File: res://.godot/global_script_class_cache.cfg
                savepack: step 102: Storing File: res://icon.svg
                savepack: step 102: Storing File: res://.godot/uid_cache.bin
                savepack: step 102: Storing File: res://project.binary
        savepack: end
        ERROR: Attempting to parent and popup a dialog that already has a parent.
           at: _try_parent_dialog (scene/main/window.cpp:1838)

        # godot exited with exit code: 0

