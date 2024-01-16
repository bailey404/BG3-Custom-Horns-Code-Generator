Public Class Main

    Public Function GenUUID() As String 'Generates the UUID, converts it to a string, and returns that string.
        Dim gennedUUID As Guid = Guid.NewGuid()
        Dim gennedUUIDAsString As String = gennedUUID.ToString()

        Return gennedUUIDAsString
    End Function

    Public Function GenHandle() As String 'Like the GenUUID function but specifically for the TranslationString handle because it's a weird format.
        Dim initialUUID As Guid = Guid.NewGuid()
        Dim UUIDAsString As String = initialUUID.ToString()
        Dim convertedToSpecialSnowflake As String = "h" & Replace(UUIDAsString, "-", "f") 'The format of the TranslationString handle is a regular UUID but an h is added at the beginning and the dashes (-) are replaced with fs.

        Return convertedToSpecialSnowflake
    End Function

    Public Function GenMeshUUIDs() 'Exactly what it says on the tin.
        tbox_UUID_hum_M.Text = GenUUID()
        tbox_UUID_hum_MS.Text = GenUUID()
        tbox_UUID_hum_F.Text = GenUUID()
        tbox_UUID_hum_FS.Text = GenUUID()
        tbox_UUID_tif_M.Text = GenUUID()
        tbox_UUID_tif_MS.Text = GenUUID()
        tbox_UUID_tif_F.Text = GenUUID()
        tbox_UUID_tif_FS.Text = GenUUID()
        tbox_UUID_git_M.Text = GenUUID()
        tbox_UUID_git_F.Text = GenUUID()
        tbox_UUID_dwr_M.Text = GenUUID()
        tbox_UUID_dwr_F.Text = GenUUID()
        tbox_UUID_hlf_M.Text = GenUUID()
        tbox_UUID_hlf_F.Text = GenUUID()
        tbox_UUID_gnm_M.Text = GenUUID()
        tbox_UUID_gnm_F.Text = GenUUID()
        tbox_UUID_dgb_M.Text = GenUUID()
        tbox_UUID_dgb_F.Text = GenUUID()
        tbox_UUID_orc_M.Text = GenUUID()
        tbox_UUID_orc_F.Text = GenUUID()
    End Function

    Public Function GenTextureUUIDs() 'Exactly what it says on the tin.
        tbox_UUID_material.Text = GenUUID()
        tbox_UUID_PM.Text = GenUUID()
        tbox_UUID_BM.Text = GenUUID()
        tbox_UUID_NM.Text = GenUUID()
        tbox_UUID_MSK.Text = GenUUID()
    End Function

    Public Function GetFilePath(filterType) As String 'This is to get the file path needed for the snippet generation. It returns the path to the chosen file starting inside the "Generated" folder.
        Dim filePath As String
        Using OpenFileDialog = New OpenFileDialog()
            If filterType = "DDS" Then
                OpenFileDialog.Filter = "DDS Files (*.dds)|*.dds"
            End If
            If filterType = "GR2" Then
                OpenFileDialog.Filter = "GR2 Files (*.GR2)|*.GR2"
            End If
            If OpenFileDialog.ShowDialog() = DialogResult.OK Then
                filePath = OpenFileDialog.FileName
                Dim filePathArray() As String = Split(filePath, Delimiter:="Generated")
                Return "Generated" & filePathArray(1) 'I'm sure there's a way to concatenate in the declaration but that optimization is low priority right now.
            End If
        End Using
    End Function

    Public Function ClearMeshPaths() 'Exactly what it says on the tin.
        tbox_path_humanoid_M.Text = ""
        tbox_path_humanoid_MS.Text = ""
        tbox_path_humanoid_F.Text = ""
        tbox_path_humanoid_FS.Text = ""
        tbox_path_tif_M.Text = ""
        tbox_path_tif_MS.Text = ""
        tbox_path_tif_F.Text = ""
        tbox_path_tif_FS.Text = ""
        tbox_path_gith_M.Text = ""
        tbox_path_gith_F.Text = ""
        tbox_path_dwarf_M.Text = ""
        tbox_path_dwarf_F.Text = ""
        tbox_path_half_M.Text = ""
        tbox_path_half_F.Text = ""
        tbox_path_gnome_M.Text = ""
        tbox_path_gnome_F.Text = ""
        tbox_path_dragon_M.Text = ""
        tbox_path_dragon_F.Text = ""
        tbox_path_orc_M.Text = ""
        tbox_path_orc_F.Text = ""
    End Function

    Public Function ClearTexturePaths() 'Exactly what it says on the tin.
        tbox_path_PM.Text = ""
        tbox_path_BM.Text = ""
        tbox_path_NM.Text = ""
        tbox_path_MSK.Text = ""
    End Function

    Public Function ClearMeshUUIDS() 'Exactly what it says on the tin.
        tbox_UUID_hum_M.Text = ""
        tbox_UUID_hum_MS.Text = ""
        tbox_UUID_hum_F.Text = ""
        tbox_UUID_hum_FS.Text = ""
        tbox_UUID_tif_M.Text = ""
        tbox_UUID_tif_MS.Text = ""
        tbox_UUID_tif_F.Text = ""
        tbox_UUID_tif_FS.Text = ""
        tbox_UUID_git_M.Text = ""
        tbox_UUID_git_F.Text = ""
        tbox_UUID_dwr_M.Text = ""
        tbox_UUID_dwr_F.Text = ""
        tbox_UUID_hlf_M.Text = ""
        tbox_UUID_hlf_F.Text = ""
        tbox_UUID_gnm_M.Text = ""
        tbox_UUID_gnm_F.Text = ""
        tbox_UUID_dgb_M.Text = ""
        tbox_UUID_dgb_F.Text = ""
        tbox_UUID_orc_M.Text = ""
        tbox_UUID_orc_F.Text = ""
    End Function

    Public Function ClearTextureUUIDS() 'Exactly what it says on the tin.
        tbox_UUID_material.Text = ""
        tbox_UUID_PM.Text = ""
        tbox_UUID_BM.Text = ""
        tbox_UUID_NM.Text = ""
        tbox_UUID_MSK.Text = ""
    End Function

    Public Function ClearAllFields() 'Exactly what it says on the tin. Calls all clear functions at once.
        ClearMeshPaths()
        ClearTexturePaths()
        ClearMeshUUIDS()
        ClearTextureUUIDS()
    End Function

    Public Function ClearSnippets()  'Exactly what it says on the tin.
        tbox_output_mergedMaterial.Text = ""
        tbox_output_mergedTextures.Text = ""
        tbox_output_mergedMesh.Text = ""
        tbox_output_CCAV.Text = ""
        tbox_output_loca.Text = ""
    End Function

    Public Function GenMergedMaterialSnip()
        Dim inputFile As String = My.Resources.Snips.merged_material_snip_input 'Pulls the trmplate from the resX file.
        Dim placeholder_material = New String() {"DISPLAYED_NAME", "UUID_MATERIAL", "TEXTURE_PREFIX", "UUID_NM", "UUID_BM", "UUID_MSK", "UUID_PM"}
        'An array of the placeholders to be swapped out.
        Dim input_material = New String() {tbox_displayed_name.Text, tbox_UUID_material.Text, tbox_texture_prefix.Text, tbox_UUID_NM.Text, tbox_UUID_BM.Text, tbox_UUID_MSK.Text, tbox_UUID_PM.Text}
        'An array of the inputs to be swapped out.
        Dim steppy As Integer = 0

        While steppy < placeholder_material.Length
            inputFile = inputFile.Replace(placeholder_material(steppy), input_material(steppy)) 'Replaces the placeholder with the input from the parallel array.
            steppy += 1
        End While

        tbox_output_mergedMaterial.Text = inputFile
    End Function

    Public Function GenMergedTextureSnip()
        Dim inputFile As String = My.Resources.Snips.merged_texture_snip_input 'Pulls the trmplate from the resX file.
        Dim placeholder_texture = New String() {"DISPLAYED_NAME", "TEXTURE_PREFIX", "UUID_PM", "PATH_PM", "UUID_BM", "PATH_BM",
                                                "UUID_NM", "PATH_NM", "UUID_MSK", "PATH_MSK"}
        'An array of the placeholders to be swapped out.
        Dim input_texture = New String() {tbox_displayed_name.Text, tbox_texture_prefix.Text, tbox_UUID_PM.Text, tbox_path_PM.Text, tbox_UUID_BM.Text, tbox_path_BM.Text,
                                            tbox_UUID_NM.Text, tbox_path_NM.Text, tbox_UUID_MSK.Text, tbox_path_MSK.Text}
        'An array of the inputs to be swapped out.
        Dim steppy As Integer = 0

        While steppy < placeholder_texture.Length
            inputFile = inputFile.Replace(placeholder_texture(steppy), input_texture(steppy)) 'Replaces the placeholder with the input from the parallel array.
            steppy += 1
        End While

        tbox_output_mergedTextures.Text = inputFile
    End Function


    Public Function GenMergedMeshSnip()
        Dim inputFile As String = My.Resources.Snips.merged_mesh_snip_input 'Pulls the trmplate from the resX file.
        Dim placeholder_mesh = New String() {"DISPLAYED_NAME", "MESH_PREFIX", "UUID_MATERIAL", "UUID_HUM_FS", "UUID_HUM_MS", "UUID_HUM_F", "UUID_HUM_M",
                                                "UUID_TIF_FS", "UUID_TIF_MS", "UUID_TIF_F", "UUID_TIF_M", "UUID_GTY_F", "UUID_GTY_M",
                                                "UUID_DWR_F", "UUID_DWR_M", "UUID_HLF_F", "UUID_HLF_M", "UUID_GNO_F", "UUID_GNO_M",
                                                "UUID_DGB_F", "UUID_DGB_M", "UUID_HRC_F", "UUID_HRC_M", "PATH_HUMANOID_FS", "PATH_HUMANOID_MS",
                                                "PATH_HUMANOID_F", "PATH_HUMANOID_M", "PATH_TIF_FS", "PATH_TIF_MS", "PATH_TIF_F", "PATH_TIF_M",
                                                "PATH_GTY_F", "PATH_GTY_M", "PATH_DWR_F", "PATH_DWR_M", "PATH_HLF_F", "PATH_HLF_M",
                                                "PATH_GNO_F", "PATH_GNO_M", "PATH_DGB_F", "PATH_DGB_M", "PATH_HRC_F", "PATH_HRC_M"}
        'An array of the placeholders to be swapped out.
        Dim input_mesh = New String() {tbox_displayed_name.Text, tbox_mesh_prefix.Text, tbox_UUID_material.Text, tbox_UUID_hum_FS.Text, tbox_UUID_hum_MS.Text, tbox_UUID_hum_F.Text, tbox_UUID_hum_M.Text,
                                        tbox_UUID_tif_FS.Text, tbox_UUID_tif_MS.Text, tbox_UUID_tif_F.Text, tbox_UUID_tif_M.Text, tbox_UUID_git_F.Text, tbox_UUID_git_M.Text,
                                        tbox_UUID_dwr_F.Text, tbox_UUID_dwr_M.Text, tbox_UUID_hlf_F.Text, tbox_UUID_hlf_M.Text, tbox_UUID_gnm_F.Text, tbox_UUID_gnm_M.Text,
                                        tbox_UUID_dgb_F.Text, tbox_UUID_dgb_M.Text, tbox_UUID_orc_F.Text, tbox_UUID_orc_M.Text, tbox_path_humanoid_FS.Text, tbox_path_humanoid_MS.Text,
                                        tbox_path_humanoid_F.Text, tbox_path_humanoid_M.Text, tbox_path_tif_FS.Text, tbox_path_tif_MS.Text, tbox_path_tif_F.Text, tbox_path_tif_M.Text,
                                        tbox_path_gith_F.Text, tbox_path_gith_M.Text, tbox_path_dwarf_F.Text, tbox_path_dwarf_M.Text, tbox_path_half_F.Text, tbox_path_half_M.Text,
                                        tbox_path_gnome_F.Text, tbox_path_gnome_M.Text, tbox_path_dragon_F.Text, tbox_path_dragon_M.Text, tbox_path_orc_F.Text, tbox_path_orc_M.Text}
        'An array of the inputs to be swapped out.
        Dim steppy As Integer = 0

        While steppy < input_mesh.Length
            input_mesh(steppy) = input_mesh(steppy).Replace(".GR2", "") 'This is removing the .GR2 from any file paths just so that it's easier to make the dummy paths.
            steppy += 1
        End While

        steppy = 0

        While steppy < placeholder_mesh.Length
            inputFile = inputFile.Replace(placeholder_mesh(steppy), input_mesh(steppy)) 'Replaces the placeholder with the input from the parallel array.
            steppy += 1
        End While

        tbox_output_mergedMesh.Text = inputFile
    End Function

    Public Function GenMergedSnips()
        GenMergedMaterialSnip()
        GenMergedTextureSnip()
        GenMergedMeshSnip()
    End Function

    Public Function GenCCAVSnip()
        Dim inputFile As String = My.Resources.Snips.CCAV_snip_input 'Pulls the template from the resX file.
        Dim placeholder_CCAV = New String() {"DISPLAYED_NAME", "NAMEHANDLE", "UUID_HUM_FS", "UUID_HUM_MS", "UUID_HUM_F", "UUID_HUM_M",
                                                "UUID_TIF_FS", "UUID_TIF_MS", "UUID_TIF_F", "UUID_TIF_M", "UUID_GTY_F", "UUID_GTY_M",
                                                "UUID_DWR_F", "UUID_DWR_M", "UUID_HLF_F", "UUID_HLF_M", "UUID_GNO_F", "UUID_GNO_M",
                                                "UUID_DGB_F", "UUID_DGB_M", "UUID_HRC_F", "UUID_HRC_M", "CCAV_HUM_FS", "CCAV_HUM_MS",
                                                "CCAV_HUM_F", "CCAV_HUM_M", "CCAV_ELF_FS", "CCAV_ELF_MS", "CCAV_ELF_F", "CCAV_ELF_M",
                                                "CCAV_HEL_FS", "CCAV_HEL_MS", "CCAV_HEL_F", "CCAV_HEL_M", "CCAV_DRO_FS", "CCAV_DRO_MS",
                                                "CCAV_DRO_F", "CCAV_DRO_M", "CCAV_TIF_FS", "CCAV_TIF_MS", "CCAV_TIF_F", "CCAV_TIF_M",
                                                "CCAV_GTY_F", "CCAV_GTY_M", "CCAV_DWR_F", "CCAV_DWR_M", "CCAV_HLF_F", "CCAV_HLF_M",
                                                "CCAV_GNO_F", "CCAV_GNO_M", "CCAV_DGB_F", "CCAV_DGB_M", "CCAV_DGB_F", "CCAV_DGB_M"}
        'An array of the placeholders to be swapped out.
        Dim input_CCAV = New String() {tbox_displayed_name.Text, tbox_namehandle.Text, tbox_UUID_hum_FS.Text, tbox_UUID_hum_MS.Text, tbox_UUID_hum_F.Text, tbox_UUID_hum_M.Text,
                                        tbox_UUID_tif_FS.Text, tbox_UUID_tif_MS.Text, tbox_UUID_tif_F.Text, tbox_UUID_tif_M.Text, tbox_UUID_git_F.Text, tbox_UUID_git_M.Text,
                                        tbox_UUID_dwr_F.Text, tbox_UUID_dwr_M.Text, tbox_UUID_hlf_F.Text, tbox_UUID_hlf_M.Text, tbox_UUID_gnm_F.Text, tbox_UUID_gnm_M.Text,
                                        tbox_UUID_dgb_F.Text, tbox_UUID_dgb_M.Text, tbox_UUID_orc_F.Text, tbox_UUID_orc_M.Text, GenUUID(), GenUUID(),
                                        GenUUID(), GenUUID(), GenUUID(), GenUUID(), GenUUID(), GenUUID(),
                                        GenUUID(), GenUUID(), GenUUID(), GenUUID(), GenUUID(), GenUUID(),
                                        GenUUID(), GenUUID(), GenUUID(), GenUUID(), GenUUID(), GenUUID(),
                                        GenUUID(), GenUUID(), GenUUID(), GenUUID(), GenUUID(), GenUUID(),
                                        GenUUID(), GenUUID(), GenUUID(), GenUUID(), GenUUID(), GenUUID()}
        'An array of the inputs to be swapped out. The chunk of UUID generator functions are for specific CCAV UUIDs for each race/build combo.
        'Since they don't appear anywhere else in the files, they're getting generated here.
        'I'm sure there's a better way to do that than pasting the same function call 30+ times but that's optimization for a later date.
        Dim steppy As Integer = 0

        While steppy < placeholder_CCAV.Length
            inputFile = inputFile.Replace(placeholder_CCAV(steppy), input_CCAV(steppy)) 'Replaces the placeholder with the input from the parallel array.
            steppy += 1
        End While

        tbox_output_CCAV.Text = inputFile 'Displays the final generated text in the proper text box.

    End Function

    Public Function GenLocaSnip()
        Dim inputFile As String = My.Resources.Snips.loca_snip_input 'Pulls the template from the resX file.

        inputFile = inputFile.Replace("UUIDhandle", tbox_namehandle.Text) 'Replaces the TranslationString handle placeholder with the generated handle.
        inputFile = inputFile.Replace("DISPLAYED_NAME", tbox_displayed_name.Text) 'Replaces the Option Name placeholder with the input Display Name.

        tbox_output_loca.Text = inputFile 'Shows the converted template in the output window.
    End Function

    Private Sub btn_gen_handle_Click(sender As Object, e As EventArgs) Handles btn_gen_handle.Click
        Dim nameHandle As String = GenHandle() 'Generating the TranslationString handle.

        tbox_namehandle.Text = nameHandle 'Populating the box with the generated handle.
    End Sub
    Private Sub btn_gen_meshUUID_Click(sender As Object, e As EventArgs) Handles btn_gen_meshUUID.Click
        GenMeshUUIDs()
    End Sub
    Private Sub btn_gen_textureUUID_Click(sender As Object, e As EventArgs) Handles btn_gen_textureUUID.Click
        GenTextureUUIDs()
    End Sub
    Private Sub btn_gen_allUUID_Click(sender As Object, e As EventArgs) Handles btn_gen_allUUID.Click
        GenMeshUUIDs()
        GenTextureUUIDs()
    End Sub
    Private Sub btn_gen_snippets_Click(sender As Object, e As EventArgs) Handles btn_gen_snippets.Click
        If cbox_merged.Checked Then
            GenMergedSnips()
        End If
        If cbox_CCAV.Checked Then
            GenCCAVSnip()
        End If
        If cbox_loca.Checked Then
            GenLocaSnip()
        End If
    End Sub

    Private Sub btn_path_humanoid_M_Click(sender As Object, e As EventArgs) Handles btn_path_humanoid_M.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_humanoid_M.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_humanoid_F_Click(sender As Object, e As EventArgs) Handles btn_path_humanoid_F.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_humanoid_F.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_humanoid_MS_Click(sender As Object, e As EventArgs) Handles btn_path_humanoid_MS.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_humanoid_MS.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_humanoid_FS_Click(sender As Object, e As EventArgs) Handles btn_path_humanoid_FS.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_humanoid_FS.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_tief_M_Click(sender As Object, e As EventArgs) Handles btn_path_tief_M.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_tif_M.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_tief_MS_Click(sender As Object, e As EventArgs) Handles btn_path_tief_MS.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_tif_MS.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_tief_F_Click(sender As Object, e As EventArgs) Handles btn_path_tief_F.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_tif_F.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_tief_FS_Click(sender As Object, e As EventArgs) Handles btn_path_tief_FS.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_tif_FS.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_gith_M_Click(sender As Object, e As EventArgs) Handles btn_path_gith_M.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_gith_M.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_dwarf_M_Click(sender As Object, e As EventArgs) Handles btn_path_dwarf_M.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_dwarf_M.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_gith_F_Click(sender As Object, e As EventArgs) Handles btn_path_gith_F.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_gith_F.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_dwarf_F_Click(sender As Object, e As EventArgs) Handles btn_path_dwarf_F.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_dwarf_F.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_half_M_Click(sender As Object, e As EventArgs) Handles btn_path_half_M.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_half_M.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_gnome_M_Click(sender As Object, e As EventArgs) Handles btn_path_gnome_M.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_gnome_M.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_half_F_Click(sender As Object, e As EventArgs) Handles btn_path_half_F.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_half_F.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_gnome_F_Click(sender As Object, e As EventArgs) Handles btn_path_gnome_F.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_gnome_F.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_dragon_M_Click(sender As Object, e As EventArgs) Handles btn_path_dragon_M.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_dragon_M.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_orc_M_Click(sender As Object, e As EventArgs) Handles btn_path_orc_M.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_orc_M.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_dragon_F_Click(sender As Object, e As EventArgs) Handles btn_path_dragon_F.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_dragon_F.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_orc_F_Click(sender As Object, e As EventArgs) Handles btn_path_orc_F.Click
        Dim filePath = GetFilePath("GR2")
        tbox_path_orc_F.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_PM_Click(sender As Object, e As EventArgs) Handles btn_path_PM.Click
        Dim filePath = GetFilePath("DDS")
        tbox_path_PM.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_BM_Click(sender As Object, e As EventArgs) Handles btn_path_BM.Click
        Dim filePath = GetFilePath("DDS")
        tbox_path_BM.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_NM_Click(sender As Object, e As EventArgs) Handles btn_path_NM.Click
        Dim filePath = GetFilePath("DDS")
        tbox_path_NM.Text = filePath.Replace("\", "/")
    End Sub
    Private Sub btn_path_MSK_Click(sender As Object, e As EventArgs) Handles btn_path_MSK.Click
        Dim filePath = GetFilePath("DDS")
        tbox_path_MSK.Text = filePath.Replace("\", "/")
    End Sub

    Private Sub btn_clear_meshpath_Click(sender As Object, e As EventArgs) Handles btn_clear_meshpath.Click
        If MessageBox.Show("This will clear ALL Mesh Path fields, are you sure?", "Confirm Clear", MessageBoxButtons.YesNo) = DialogResult.Yes Then 'Pops up a confirmation dialog before clearing.
            ClearMeshPaths()
        End If
    End Sub

    Private Sub btn_clear_texturepath_Click(sender As Object, e As EventArgs) Handles btn_clear_texturepath.Click
        If MessageBox.Show("This will clear ALL Texture Path fields, are you sure?", "Confirm Clear", MessageBoxButtons.YesNo) = DialogResult.Yes Then 'Pops up a confirmation dialog before clearing.
            ClearTexturePaths()
        End If
    End Sub

    Private Sub btn_clear_meshUUID_Click(sender As Object, e As EventArgs) Handles btn_clear_meshUUID.Click
        If MessageBox.Show("This will clear ALL Mesh UUID fields, are you sure?", "Confirm Clear", MessageBoxButtons.YesNo) = DialogResult.Yes Then 'Pops up a confirmation dialog before clearing.
            ClearMeshUUIDS()
        End If
    End Sub

    Private Sub btn_clear_textureUUID_Click(sender As Object, e As EventArgs) Handles btn_clear_textureUUID.Click
        If MessageBox.Show("This will clear ALL Texture UUIDs, are you sure?", "Confirm Clear", MessageBoxButtons.YesNo) = DialogResult.Yes Then 'Pops up a confirmation dialog before clearing.
            ClearTextureUUIDS()
        End If
    End Sub

    Private Sub btn_clear_all_Click(sender As Object, e As EventArgs) Handles btn_clear_all.Click
        If MessageBox.Show("This will clear ALL File and UUID input fields, are you sure?", "Confirm Clear", MessageBoxButtons.YesNo) = DialogResult.Yes Then 'Pops up a confirmation dialog before clearing.
            ClearMeshPaths()
            ClearTexturePaths()
            ClearMeshUUIDS()
            ClearTextureUUIDS()
        End If
    End Sub

    Private Sub menu_settings_1click_copy_Click(sender As Object, e As EventArgs) Handles menu_settings_1click_copy.Click
        Dim isOptionChecked = menu_settings_1click_copy.Checked
        Select Case (isOptionChecked)
            Case "True"
                menu_settings_1click_copy.Checked = False
            Case "False"
                menu_settings_1click_copy.Checked = True
        End Select
    End Sub

    Private Sub tbox_output_mergedMaterial_Click(sender As Object, e As EventArgs) Handles tbox_output_mergedMaterial.Click
        If menu_settings_1click_copy.Checked Then
            My.Computer.Clipboard.SetText(tbox_output_mergedMaterial.Text)
            tbox_output_mergedMaterial.SelectionStart = 0
            tbox_output_mergedMaterial.SelectionLength = tbox_output_mergedMaterial.Text.Length
        End If
    End Sub

    Private Sub tbox_output_mergedTextures_Click(sender As Object, e As EventArgs) Handles tbox_output_mergedTextures.Click
        If menu_settings_1click_copy.Checked Then
            My.Computer.Clipboard.SetText(tbox_output_mergedTextures.Text)
            tbox_output_mergedTextures.SelectionStart = 0
            tbox_output_mergedTextures.SelectionLength = tbox_output_CCAV.Text.Length
        End If
    End Sub

    Private Sub tbox_output_mergedMesh_Click(sender As Object, e As EventArgs) Handles tbox_output_mergedMesh.Click
        If menu_settings_1click_copy.Checked Then
            My.Computer.Clipboard.SetText(tbox_output_mergedMesh.Text)
            tbox_output_mergedMesh.SelectionStart = 0
            tbox_output_mergedMesh.SelectionLength = tbox_output_mergedMesh.Text.Length
        End If
    End Sub

    Private Sub tbox_output_CCAV_Click(sender As Object, e As EventArgs) Handles tbox_output_CCAV.Click
        If menu_settings_1click_copy.Checked Then
            My.Computer.Clipboard.SetText(tbox_output_CCAV.Text)
            tbox_output_CCAV.SelectionStart = 0
            tbox_output_CCAV.SelectionLength = tbox_output_CCAV.Text.Length
        End If
    End Sub

    Private Sub tbox_output_loca_Click(sender As Object, e As EventArgs) Handles tbox_output_loca.Click
        If menu_settings_1click_copy.Checked Then
            My.Computer.Clipboard.SetText(tbox_output_loca.Text)
            tbox_output_loca.SelectionStart = 0
            tbox_output_loca.SelectionLength = tbox_output_loca.Text.Length
        End If
    End Sub

    Private Sub lbl_help_displayed_name_MouseEnter(sender As Object, e As EventArgs) Handles lbl_help_displayed_name.MouseEnter
        ToolTip.SetToolTip(lbl_help_displayed_name, "The name that will show up in Character Creation")
    End Sub

    Private Sub lbl_help_mesh_prefix_MouseEnter(sender As Object, e As EventArgs) Handles lbl_help_mesh_prefix.MouseEnter
        ToolTip.SetToolTip(lbl_help_mesh_prefix, "Part of the file name that indicates the horn type: [Race]_[BodyType]_MeshPrefix.GR2")
    End Sub

    Private Sub lbl_help_texture_prefix_MouseEnter(sender As Object, e As EventArgs) Handles lbl_help_texture_prefix.MouseEnter
        ToolTip.SetToolTip(lbl_help_texture_prefix, "Part of the file name before the texture type indicator: TexturePrefix_[TextureType].dds")
    End Sub

    Private Sub btn_clear_snippets_Click(sender As Object, e As EventArgs) Handles btn_clear_snippets.Click
        tbox_output_CCAV.Text = ""
        tbox_output_loca.Text = ""
        tbox_output_mergedMaterial.Text = ""
        tbox_output_mergedMesh.Text = ""
        tbox_output_mergedTextures.Text = ""
    End Sub
End Class