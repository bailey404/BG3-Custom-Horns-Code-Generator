﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Snips
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("BG3_ACHCG.Snips", GetType(Snips).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!-- Humans - 0eb594cb-8820-4be6-a58d-8be7a1a98fba --&gt;		
        '''
        '''			&lt;!-- ======== DISPLAYED_NAME F ========== --&gt;
        '''            &lt;node id=&quot;CharacterCreationAppearanceVisual&quot;&gt;
        '''			&lt;!-- Default bodyshape = 0, alternate bodyshape = 1 --&gt;
        '''                    &lt;attribute id=&quot;BodyShape&quot; type=&quot;uint8&quot; value=&quot;0&quot;/&gt;
        '''			&lt;!-- Masc = 0 , Fem = 1 --&gt;
        '''                    &lt;attribute id=&quot;BodyType&quot; type=&quot;uint8&quot; value=&quot;1&quot;/&gt;
        '''			&lt;!-- This matches the .loca file that stores the names --&gt;
        '''                    &lt;attribute id=&quot;DisplayNam [rest of string was truncated]&quot;;.
        '''</summary>
        Friend Shared ReadOnly Property CCAV_snip_input() As String
            Get
                Return ResourceManager.GetString("CCAV_snip_input", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;content contentuid=&quot;UUIDhandle&quot; version=&quot;1&quot;&gt;DISPLAYED_NAME&lt;/content&gt;.
        '''</summary>
        Friend Shared ReadOnly Property loca_snip_input() As String
            Get
                Return ResourceManager.GetString("loca_snip_input", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!-- ======================= DISPLAYED_NAME Material ====================== --&gt;
        '''			&lt;node id=&quot;Resource&quot;&gt;
        '''					&lt;attribute id=&quot;DiffusionProfileUUID&quot; type=&quot;FixedString&quot; value=&quot;&quot; /&gt;
        '''	&lt;!-- Referenced in VisualBank as the MaterialID  --&gt;
        '''					&lt;attribute id=&quot;ID&quot; type=&quot;FixedString&quot; value=&quot;UUID_MATERIAL&quot; /&gt;
        '''					&lt;attribute id=&quot;MaterialType&quot; type=&quot;uint8&quot; value=&quot;18&quot; /&gt;
        '''	&lt;!-- Horns texture file prefix  --&gt;
        '''					&lt;attribute id=&quot;Name&quot; type=&quot;LSString&quot; value=&quot;TEXTURE_PREFIX&quot; /&gt;
        '''	&lt;!-- This is the same for all horns, d [rest of string was truncated]&quot;;.
        '''</summary>
        Friend Shared ReadOnly Property merged_material_snip_input() As String
            Get
                Return ResourceManager.GetString("merged_material_snip_input", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!-- +++++++++++++++++++++++ Humanoid +++++++++++++++++++++++++++++++++++++ --&gt;
        '''
        '''&lt;!-- ========================= DISPLAYED_NAME F ================================ --&gt;
        '''				
        '''			&lt;node id=&quot;Resource&quot;&gt;
        '''					&lt;attribute id=&quot;AttachBone&quot; type=&quot;FixedString&quot; value=&quot;&quot; /&gt;
        '''					&lt;attribute id=&quot;AttachmentSkeletonResource&quot; type=&quot;FixedString&quot; value=&quot;&quot; /&gt;
        '''					&lt;attribute id=&quot;BlueprintInstanceResourceID&quot; type=&quot;FixedString&quot; value=&quot;&quot; /&gt;  				
        '''					&lt;attribute id=&quot;BoundsMax&quot; type=&quot;fvec3&quot; value=&quot;0.2241342 1.923792 0.08434314&quot; [rest of string was truncated]&quot;;.
        '''</summary>
        Friend Shared ReadOnly Property merged_mesh_snip_input() As String
            Get
                Return ResourceManager.GetString("merged_mesh_snip_input", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!-- ================== DISPLAYED_NAME Textures ======================= --&gt;
        '''			
        '''&lt;!-- Physical Map --&gt;
        '''
        '''&lt;node id=&quot;Resource&quot;&gt;
        '''					&lt;attribute id=&quot;Depth&quot; type=&quot;int32&quot; value=&quot;1&quot; /&gt;
        '''					&lt;attribute id=&quot;Height&quot; type=&quot;int32&quot; value=&quot;1024&quot; /&gt;
        '''	&lt;!-- Referenced in MaterialBank --&gt;				
        '''					&lt;attribute id=&quot;ID&quot; type=&quot;FixedString&quot; value=&quot;UUID_PM&quot; /&gt;
        '''	&lt;!-- Match file name --&gt;
        '''					&lt;attribute id=&quot;Name&quot; type=&quot;LSString&quot; value=&quot;TEXTURE_PREFIX_PM&quot; /&gt;
        '''					&lt;attribute id=&quot;SRGB&quot; type=&quot;bool&quot; value=&quot;False&quot; /&gt;
        '''	&lt;!-- Textu [rest of string was truncated]&quot;;.
        '''</summary>
        Friend Shared ReadOnly Property merged_texture_snip_input() As String
            Get
                Return ResourceManager.GetString("merged_texture_snip_input", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
