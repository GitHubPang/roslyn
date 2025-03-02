﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Editor.ColorSchemes;

namespace Microsoft.VisualStudio.LanguageServices.CSharp.Options
{
    internal static class AdvancedOptionPageStrings
    {
        public static string Option_Analysis
            => ServicesVSResources.Analysis;

        public static string Option_Background_analysis_scope
            => ServicesVSResources.Background_analysis_scope_colon;

        public static string Option_Background_Analysis_Scope_Active_File
            => ServicesVSResources.Current_document;

        public static string Option_Background_Analysis_Scope_Open_Files_And_Projects
            => ServicesVSResources.Open_documents;

        public static string Option_Background_Analysis_Scope_Full_Solution
            => ServicesVSResources.Entire_solution;

        public static string Option_Enable_navigation_to_decompiled_sources
            => ServicesVSResources.Enable_navigation_to_decompiled_sources;

        public static string Option_Enable_pull_diagnostics_experimental_requires_restart
            => ServicesVSResources.Enable_pull_diagnostics_experimental_requires_restart;

        public static string Option_Enable_Razor_pull_diagnostics_experimental_requires_restart
            => ServicesVSResources.Enable_Razor_pull_diagnostics_experimental_requires_restart;

        public static string Option_run_code_analysis_in_separate_process
            => ServicesVSResources.Run_code_analysis_in_separate_process_requires_restart;

        public static string Option_Inline_Hints
            => ServicesVSResources.Inline_Hints;

        public static string Option_Display_all_hints_while_pressing_Alt_F1
            => ServicesVSResources.Display_all_hints_while_pressing_Alt_F1;

        public static string Option_Color_hints
            => ServicesVSResources.Color_hints;

        public static string Option_Display_inline_parameter_name_hints
            => ServicesVSResources.Display_inline_parameter_name_hints;

        public static string Option_Show_hints_for_literals
            => ServicesVSResources.Show_hints_for_literals;

        public static string Option_Show_hints_for_new_expressions
            => CSharpVSResources.Show_hints_for_new_expressions;

        public static string Option_Show_hints_for_everything_else
            => ServicesVSResources.Show_hints_for_everything_else;

        public static string Option_Show_hints_for_indexers
            => ServicesVSResources.Show_hints_for_indexers;

        public static string Option_Suppress_hints_when_parameter_name_matches_the_method_s_intent
            => ServicesVSResources.Suppress_hints_when_parameter_name_matches_the_method_s_intent;

        public static string Option_Suppress_hints_when_parameter_names_differ_only_by_suffix
            => ServicesVSResources.Suppress_hints_when_parameter_names_differ_only_by_suffix;

        public static string Option_Suppress_hints_when_argument_matches_parameter_name
            => ServicesVSResources.Suppress_hints_when_argument_matches_parameter_name;

        public static string Option_Display_inline_type_hints
            => ServicesVSResources.Display_inline_type_hints;

        public static string Option_Show_hints_for_variables_with_inferred_types
            => ServicesVSResources.Show_hints_for_variables_with_inferred_types;

        public static string Option_Show_hints_for_lambda_parameter_types
            => ServicesVSResources.Show_hints_for_lambda_parameter_types;

        public static string Option_Show_hints_for_implicit_object_creation
            => ServicesVSResources.Show_hints_for_implicit_object_creation;

        public static string Option_Display_diagnostics_inline_experimental
            => ServicesVSResources.Display_diagnostics_inline_experimental;

        public static string Option_at_the_end_of_the_line_of_code
            => ServicesVSResources.at_the_end_of_the_line_of_code;

        public static string Option_on_the_right_edge_of_the_editor_window
            => ServicesVSResources.on_the_right_edge_of_the_editor_window;

        public static string Option_RenameTrackingPreview => CSharpVSResources.Show_preview_for_rename_tracking;
        public static string Option_Split_string_literals_on_enter => CSharpVSResources.Split_string_literals_on_enter;

        public static string Option_DisplayLineSeparators
            => CSharpVSResources.Show_procedure_line_separators;

        public static string Option_Underline_reassigned_variables
            => ServicesVSResources.Underline_reassigned_variables;

        public static string Option_DontPutOutOrRefOnStruct
            => CSharpVSResources.Don_t_put_ref_or_out_on_custom_struct;

        public static string Option_EditorHelp
            => CSharpVSResources.Editor_Help;

        public static string Option_EnableHighlightKeywords
        {
            get { return CSharpVSResources.Highlight_related_keywords_under_cursor; }
        }

        public static string Option_EnableHighlightReferences
        {
            get { return CSharpVSResources.Highlight_references_to_symbol_under_cursor; }
        }

        public static string Option_EnterOutliningMode
            => CSharpVSResources.Enter_outlining_mode_when_files_open;

        public static string Option_ExtractMethod
            => CSharpVSResources.Extract_Method;

        public static string Option_Implement_Interface_or_Abstract_Class
            => ServicesVSResources.Implement_Interface_or_Abstract_Class;

        public static string Option_When_inserting_properties_events_and_methods_place_them
            => ServicesVSResources.When_inserting_properties_events_and_methods_place_them;

        public static string Option_with_other_members_of_the_same_kind
            => ServicesVSResources.with_other_members_of_the_same_kind;

        public static string Option_at_the_end
            => ServicesVSResources.at_the_end;

        public static string Option_When_generating_properties
            => ServicesVSResources.When_generating_properties;

        public static string Option_prefer_auto_properties
            => ServicesVSResources.codegen_prefer_auto_properties;

        public static string Option_prefer_throwing_properties
            => ServicesVSResources.prefer_throwing_properties;

        public static string Option_Comments
            => ServicesVSResources.Comments;

        public static string Option_GenerateXmlDocCommentsForTripleSlash
            => CSharpVSResources.Generate_XML_documentation_comments_for;

        public static string Option_InsertSlashSlashAtTheStartOfNewLinesWhenWritingSingleLineComments
            => CSharpVSResources.Insert_slash_slash_at_the_start_of_new_lines_when_writing_slash_slash_comments;

        public static string Option_InsertAsteriskAtTheStartOfNewLinesWhenWritingBlockComments
            => CSharpVSResources.Insert_at_the_start_of_new_lines_when_writing_comments;

        public static string Option_ShowRemarksInQuickInfo
            => CSharpVSResources.Show_remarks_in_Quick_Info;

        public static string Option_Highlighting
        {
            get { return CSharpVSResources.Highlighting; }
        }

        public static string Option_OptimizeForSolutionSize
        {
            get { return CSharpVSResources.Optimize_for_solution_size; }
        }

        public static string Option_OptimizeForSolutionSize_Large
            => CSharpVSResources.Large;

        public static string Option_OptimizeForSolutionSize_Regular
            => CSharpVSResources.Regular;

        public static string Option_OptimizeForSolutionSize_Small
            => CSharpVSResources.Small;

        public static string Option_Quick_Actions
            => ServicesVSResources.Quick_Actions;

        public static string Option_Compute_Quick_Actions_asynchronously_experimental
            => ServicesVSResources.Compute_Quick_Actions_asynchronously_experimental;

        public static string Option_Outlining
            => ServicesVSResources.Outlining;

        public static string Option_Show_outlining_for_declaration_level_constructs
            => ServicesVSResources.Show_outlining_for_declaration_level_constructs;

        public static string Option_Show_outlining_for_code_level_constructs
            => ServicesVSResources.Show_outlining_for_code_level_constructs;

        public static string Option_Show_outlining_for_comments_and_preprocessor_regions
            => ServicesVSResources.Show_outlining_for_comments_and_preprocessor_regions;

        public static string Option_Collapse_regions_when_collapsing_to_definitions
            => ServicesVSResources.Collapse_regions_when_collapsing_to_definitions;

        public static string Option_Block_Structure_Guides
            => ServicesVSResources.Block_Structure_Guides;

        public static string Option_Show_guides_for_declaration_level_constructs
            => ServicesVSResources.Show_guides_for_declaration_level_constructs;

        public static string Option_Show_guides_for_code_level_constructs
            => ServicesVSResources.Show_guides_for_code_level_constructs;

        public static string Option_Fading
            => ServicesVSResources.Fading;

        public static string Option_Fade_out_unused_usings
            => CSharpVSResources.Fade_out_unused_usings;

        public static string Option_Fade_out_unreachable_code
            => ServicesVSResources.Fade_out_unreachable_code;

        public static string Option_Performance
            => CSharpVSResources.Performance;

        public static string Option_PlaceSystemNamespaceFirst
            => CSharpVSResources.Place_System_directives_first_when_sorting_usings;

        public static string Option_SeparateImportGroups
            => CSharpVSResources.Separate_using_directive_groups;

        public static string Option_Using_Directives
            => CSharpVSResources.Using_Directives;

        public static string Option_Suggest_usings_for_types_in_reference_assemblies
            => CSharpVSResources.Suggest_usings_for_types_in_dotnet_framework_assemblies;

        public static string Option_Suggest_usings_for_types_in_NuGet_packages
            => CSharpVSResources.Suggest_usings_for_types_in_NuGet_packages;

        public static string Option_Add_missing_using_directives_on_paste
            => CSharpVSResources.Add_missing_using_directives_on_paste;

        public static string Option_Report_invalid_placeholders_in_string_dot_format_calls
            => CSharpVSResources.Report_invalid_placeholders_in_string_dot_format_calls;

        public static string Option_Regular_Expressions
            => ServicesVSResources.Regular_Expressions;

        public static string Option_Colorize_regular_expressions
            => ServicesVSResources.Colorize_regular_expressions;

        public static string Option_Report_invalid_regular_expressions
            => ServicesVSResources.Report_invalid_regular_expressions;

        public static string Option_Highlight_related_components_under_cursor
            => ServicesVSResources.Highlight_related_components_under_cursor;

        public static string Option_Show_completion_list
            => ServicesVSResources.Show_completion_list;

        public static string Option_Editor_Color_Scheme
            => ServicesVSResources.Editor_Color_Scheme;

        public static string Editor_color_scheme_options_are_only_available_when_using_a_color_theme_bundled_with_Visual_Studio_The_color_theme_can_be_configured_from_the_Environment_General_options_page
            => ServicesVSResources.Editor_color_scheme_options_are_only_available_when_using_a_color_theme_bundled_with_Visual_Studio_The_color_theme_can_be_configured_from_the_Environment_General_options_page;

        public static string Some_color_scheme_colors_are_being_overridden_by_changes_made_in_the_Environment_Fonts_and_Colors_options_page_Choose_Use_Defaults_in_the_Fonts_and_Colors_page_to_revert_all_customizations
            => ServicesVSResources.Some_color_scheme_colors_are_being_overridden_by_changes_made_in_the_Environment_Fonts_and_Colors_options_page_Choose_Use_Defaults_in_the_Fonts_and_Colors_page_to_revert_all_customizations;

        public static string Edit_color_scheme
            => ServicesVSResources.Editor_Color_Scheme;

        public static string Option_Color_Scheme_VisualStudio2019
            => ServicesVSResources.Visual_Studio_2019;

        public static string Option_Color_Scheme_VisualStudio2017
            => ServicesVSResources.Visual_Studio_2017;

        public static SchemeName Color_Scheme_VisualStudio2019_Tag
            => SchemeName.VisualStudio2019;

        public static SchemeName Color_Scheme_VisualStudio2017_Tag
            => SchemeName.VisualStudio2017;

        public static string Option_Show_Remove_Unused_References_command_in_Solution_Explorer_experimental
            => ServicesVSResources.Show_Remove_Unused_References_command_in_Solution_Explorer_experimental;

        public static string Enable_all_features_in_opened_files_from_source_generators_experimental
            => ServicesVSResources.Enable_all_features_in_opened_files_from_source_generators_experimental;

        public static string Option_Enable_file_logging_for_diagnostics
            => ServicesVSResources.Enable_file_logging_for_diagnostics;

        public static string Option_Skip_analyzers_for_implicitly_triggered_builds
            => ServicesVSResources.Skip_analyzers_for_implicitly_triggered_builds;

        public static string Show_inheritance_margin
            => ServicesVSResources.Show_inheritance_margin;

        public static string Combine_inheritance_margin_with_indicator_margin
            => ServicesVSResources.Combine_inheritance_margin_with_indicator_margin;

        public static string Inheritance_Margin
            => ServicesVSResources.Inheritance_Margin;
    }
}
