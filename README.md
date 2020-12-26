# NASA-WorldWind

NASA World Wind is a graphically rich 3D virtual globe for use on desktop computers running Windows. It combines NASA imagery generated from satellites that have produced Blue Marble, Landsat 7, SRTM, MODIS and more.

v1.4

Release Notes

For information covering the many new features of NASA World Wind 1.4 please see http://www.worldwindcentral.com/wiki/What%27s_new_in_1.4

SYSTEM REQUIREMENTS
===================

* Windows 2000, or XP (Vista reported to work but has problems, UAC needs to be turned off for install and during use)
* 3D graphics card (http://wiki.worldwindcentral.com/Video_Card_Compatibility)
* Internet connection
* DirectX 9.0c and Managed DirectX 9.0c (October 2005)
* .NET Framework 2.0 runtime libraries

Minimum configuration
---------------------

With the minimum configuration, performance and functionality may be less than expected.

* 700 MHz or higher CPU
* 128 MB RAM
* 1.5 GB disk space

Recommended configuration
-------------------------

* 1.4 GHz or higher CPU
* Pixel Shader 2.0 compatible graphics card
* 256 MB of RAM
* DSL/cable connection or faster
* 3 GB of disk space


NEW Feature/Fixes IN 1.4
==========================

* Plugin: Movie Recorder removed
* Plugin: KML importer updated
* Plugin: Place Finder Loader (Supports more geocoders)
* Plugin: New WMS importer with GetCapabilities support
* Plugin: Atmospheric halo replaced with sky gradient
* Plugin: Waving Flags (3D version of the flags of the world add-on)
* Plugin: GPS Tracker added
* Plugin: Anagglyph 3D added (true 3D using Red/Blue glasses)
* Data: New NRL data
* Data: Boundaries served by WMS
* Data: WFS placenames
* Core: Added what's new in 1.4 page to configuration wizard
* Core: New accurate sunshading
* Core: Support for 3D models
* Core: Atmosphere (Improved with atmospheric scattering)
* Core: Added widget support
* Core: Internal HTML Browser
* Core: Camera shakes/jitters/jumps fixed
* Widget: New scalebar
* Widget: Time controller
* Widget: 3D compass widget
* Installer: Removed background
* Installer: Mars, Moon, SDSS icons removed
* Installer: .Net 2.0 check
* Installer: Added command line tags NODOTNET, /NODX, /NOMDX) to skip detection of .NET, DirectX 9.0c, and Managed DirectX, to skip checks respectively. 

KNOWN ISSUES
============

* If you received some installer messages in English or all messages in English even though you picked another language please see http://wiki.worldwindcentral.com/Installer_Translations and click edit.
* If you installed a beta or development version of World Wind 1.4 you must manually remove your Documents and Settings\%username%\Application Data\NASA\World Wind\1.4.0.0 directory before running this version.
* Certain features, such as the waving flags plug-in, require a high end graphics card with Pixel Shader 2.0 support, you may experience graphical corruption when using these on older graphics cards.
* KML Importer does not yet support all features of the kml 2.1 spec. 

Getting help
------------

For answers to frequently asked questions, visit: http://wiki.worldwindcentral.com/World_Wind_FAQ

For an introduction to World Wind 1.4's new features, visit: http://www.worldwindcentral.com/wiki/What%27s_new_in_1.4

The World Wind Forums (http://forum.worldwindcentral.com/) are an excellent source of news, information, and peer support.  You can find an extensive knowledge base at the World Wind Wiki: http://wiki.worldwindcentral.com

To chat with other users, visit the World Wind chat room at http://chat.worldwindcentral.com or #worldwind on irc.freenode.net.

File a bug report or a feature request by logging into the World Wind issue tracker.  See http://wiki.worldwindcentral.com/World_Wind_Issues for details.


EXTRAS: ADD-ONS
===============

Some add-ons are included with this release of World Wind.  There are other great add-ons available at these pages: ttp://www.worldwindcentral.com/wiki/Add-on_Launchpad and http://wiki.worldwindcentral.com/Add-On_list

NASA-created add-ons
--------------------

Lewis and Clark
Created by Chris Maxwell

Astrobiology Field Guide
Created by Randy Kim

Landmark Catalog
Created by ShockFire, Camille Boykins, Ratna Rao, Fred Liao, Daniel Baker and David Goldfarb

Flags of the World
Created by Randy Kim


REVISION HISTORY
================

1.3.5 (May 12, 2006)

1.3.4 (April 20, 2006)

* Plugin: Atmosphere
* Plugin: Compass
* Plugin: Overview Form Loader
* Plugin: External Layer Manager Loader
* Plugin: Measuring Tool
* Plugin: Movie Recorder
* Plugin: Place Finder Loader
* Plugin: Shape File Loader
* Plugin: 3D stars
* Plugin: RSS Earthquake 2.0.2
* Plugin: Historical Quake Query 2.0
* Plugin: Global Clouds
* Plugin: Image Overlay 4
* Plugin: IC Sharp Code SharpZipLib
* Plugin: On Screen Clock
* Plugin: Favorite Icons
* Data: Mars MDIM Color
* Data: Mars MOC Geodesy Campaign 256 (ASU)
* Data: Mars MOC Geodesy Campaign 256 Fused Color
* Data: Mars MOLA Color Shaded Relief (ASU)
* Data: Mars MOLA Color Relief (JPL)
* Data: Mars MDIM 2.1 (USGS JPL)
* Data: Mars MDIM 2.1 Fused Color
* Data: Mars THEMIS Mosaic (ASU)
* Data: Mars THEMIS Mosaic Fused COlor
* Data: Mars Placename data
* Data: Landmarks
* Data: SDSS
* Data: SDSS Footprint
* Data: SDSS FIRST Footprint
* Data: WMAP Image Server
* Installer: New Mars/SDSS background
* Installer: Preserves cache when uninstalled
* Installer: Mars icon added
* Installer: Moon icon added
* Installer: SDSS icon added
* Installer: World Wind Windows Vista style icon

1.3.3.1 (Oct 25, 2005)
* Minor changes

1.3.3 (Oct 21, 2005)

* NASA Blue Marble Next Generation integrated (Issue WW-443)
* NRL Realtime weather integrated (Issue ADD-29)
* Startup Wizard enabled (WW-380)

* World changing support through menu system (Issue WW-444)
* Moon atmosphere disabled (Issue WW-445)
* Single VS.NET solution (Issue WW-361)
* Blue Marble uses terrain (Issue WW-239)
* Added transparent color for textures (Issue WW-442)
* Opacity Control for showing index of ThemeLayers (Issue WW-25)
* Added distance measuring tool (Issue WW-131)
* Configuration Wizard addresses all settings (Issue WW-301)
* Removed unused DLLs (Issue WW-333)
* Removed obsolete projects (Issue WW-347)
* Renamed Startup Wizard to Configuration Wizard (Issue WW-360)
* Seperate XML settings file for different versions (Issue WW-368)
* Plugin unloading when quiting (Issue WW-393)
* Terrain data won't download and build a mesh when terrain is disabled (Issue WW-394)
* Menu bar can remove buttons (Issue WW-399)
* Network path support (Issue WW-402)
* Bathymetry rendering (Issue WW-398)
* Tiny icon text fixed (Issue WW-400)
* Redundant rescaling icons fixed (Issue WW-423)
* SVS loads layer list fixed (Issue WW-422)
* configuration Wizard runs first (Issue WW-416)
* Mouseover text appears first (Issue WW-252)
* Improved error window during crash (Issue WW-351)
* Dynamic custom terrain loaders (Issue WW-397)
* Alpha transparency for tool bar icons (Issue WW-405)
* World Wind version number based on .exe (Issue WW-413)
* Fullscreen command from an extra running copy ignored (Issue WW-414)
* Removed non existant settings stored in app.config (Issue WW-424)
* Removed OEMPipe and Enter as zoom controls (Issue WW-420)
* Removed unused code (Issue WW-16)
* Removed unused assembly references (Issue WW-410)
* Terrain mesh code updated (Issue WW-404)
* logfile HTTP error messages formatted (Issue WW-415)
* Vsync setting added (Issue WW-409)

* NSIS script files updated to compile under NSIS 2.10
* Installer contains update for Managed DirectX 9 October 2005 

1.3.2 (Aug 13, 2005)
--------------------

* You can now toggle the opacity setting on image layers, in the property window. Layer properties windows added. (Issues WW-233, WW-238, WW-231)
* WorldWind.config is no longer used. Its settings are now stored in WorldWind.xml (local settings folder). (Issues WW-219, WW-230, WW-228)
* Download tiles in single thread (back out multithreaded downloading due to performance problems). (Issue WW-203)
* Use download queue. Improve download performance. (Issues WW-261, WW-277, WW-268, WW-248, WW-215, WW-309)
* Images are converted to DDS by default (same as 1.3.1.1). (Issue WW-321)
* New security warning dialog on plugin load. (Issue WW-214)
* Unload plugins on application shutdown. (Issue WW-216)
* Fix plugins could load multiple times. (Issue WW-232)
* Add go to URI function for plugins. (Issue WW-212)
* Add "Show Legend" to context menu for image layers with LegendImagePath tag. (Issue WW-223)
* Add OutlineText setting that outlines placenames for readability. (Issue WW-332)
* Call mouse event handlers in plugins before local handlers. (Issue WW-218)
* Remove measure tool. (Issue WW-270)
* Speed up World Wind startup, especially with large XML config files: calculate icon world coordinates when enabled instead of on startup. (Issue WW-255)
* Screenshots can again contain position info (if position info is enabled upon save). Metadata files are now created. (Issue WW-242)
* Cache, toolbar render, and tile memory usage optimizations. (Issues WW-42, WW-322, WW-325, WW-326)
* Add support for loading GIF and TIFF files. (Issues WW-28, WW-259)
* Reorganize help menu; new Credits button in About dialog. (Issues WW-260, WW-339)
* With downloadable Blue Marble (World Wind Lite), change cached Blue Marble folders so existing Blue Marble data from previous World Wind versions can be used. (Issues WW-196, WW-157, WW-201)
* Loaded images default to DXT1 format. (Issue WW-235)
* Fixed Blue Marble tiles appeared at lower altitude in 1.3.2a2 than in 1.3.1. (Issue WW-206)
* Fix WMS browser goes to the wrong location on certain SVS WMS layers. (Issue WW-312)
* Support pluggable download protocols. (Issue WW-263)
* Fix tile refresh and missed download problems. (Issue WW-160)
* Fix WMS layers not working, download progress doesn't show, and playback controls don't work. (Issues WW-207, WW-208, WW-209)
* Add support for new SVS layers. (Issue WW-236)
* "Enable plugin support" confirmation dialog removed. (Issue WW-213)
* Proxy configuration now correctly migrates from 1.3.1. (Issue WW-204)
* Terrain paths now update when the camera location changes. (Issue WW-258)
* Fix World Wind doesn't render if a toolbar icon is missing. (Issue WW-288)
* Fix anti-aliased text option wasn't working. (Issue WW-324)
* Fix changing Direct3D setting while WW is running causes an error. (Issue WW-303)
* When both position and diagnostic info are on screen, only display position info. (Issue WW-334)
* Settings dialog is now modal. (Issue WW-327)
* Fix place names truncated. (Issue WW-24)
* Fix image tiles outside of view were being downloaded. (Issue WW-296)
* Fix parts of lat/lon grid disappear near poles when tilted. (Issue WW-295)
* Optimize path list layer. (Issue WW-244)
* Fix layer manager sluggish when many nodes are open. (Issue WW-220)
* Fix duplicate icons in layer manager. (Issue WW-166)
* Fix using opacity with transparent layers renders transparent areas black. (Issue WW-241)
* Remember place name on/off setting from last session. (Issue WW-247)
* Make plugin icons come to the foreground on mouseover. (Issue WW-246)
* Fix turning place names on/off toggles all other label layers too. (Issue WW-269)


1.3.1.1 (May 26, 2005)
----------------------

* Community Landsat server changes and optimizations.  (Issue WW-13)
* NLT Landsat server change.  (Issue WW-13)
* Hang during font install fixed.  (Issue WW-34)
* Estonian and Hungarian installer translations added; other translation fixes.  (Issue WW-13)
* 1.3.1.1 patch upgrades both 1.3 and 1.3.1.  (Issue WW-85)


1.3.1 (March 29, 2005)
----------------------

* Tile downloading optimizations
* New measure tool (press "M" key)
* New menu item to redownload imagery for the current view
* Added icon layer mouseover text
* Fixed bug with downloading tiles outside bounding box
* Added minimum and maximum display altitude for TerrainPath layers
* LayerSet.xsd schema changes; add-ons for previous versions may need to be updated
* Added optional anti-aliasing of placenames (configure in the World Settings window, Alt+W)
* Cache: .txt placeholders for tile not found errors now deleted after one day
* For certain user interface elements, World Wind now uses the World Wind Dings font instead of Wingdings 2 and Wingdings 3
* Added command line option "/f" for full screen
* "Planet Gravity" renamed to "Planet Inertia"
* Added distance, tilt, and field of view to extended position information
* When Tahoma font isn't available, default system font is now used
* Installer: translations added or fixed for several languages; corrupt installer bug fixed
* TerrainAccessor now saves terrain cache in \Cache\Earth instead of \Cache
* Local settings directory moved from \Documents and Settings\[user]\Application Data\NASA\NASA World Wind\[version] to \Documents and Settings\[user]\Application Data\NASA\World Wind 1.3
* Source code now builds under NAnt 
* 3 new community-contributed add-ons: Highest Mountains; Population Density; and World Cities.

1.3 (March 2, 2005)
-------------------

* Significant user interface improvements, including tile download indicator
* New NLT Landsat7 dataset
* New NLT elevation dataset
* New community Landsat7 mirror dataset from WorldWindCentral.com
* Camera: added planet gravity, camera banking, field-of-view, and axis lock options.  Planet gravity is on by default
* Place finder: fast search with index generator, columns, favorites, history, GPX coordinate import/export
* Scripting capability added, based on 1.0 specification (Tom Gaskins, NASA: http://worldwind.arc.nasa.gov/dev/World%20Wind%20Scripting%201.0-2005-02-12.doc)
* Now interprets new worldwind://wmsimage= URI format
* Provincial borders added for Canada, municipal borders added for Norway and Sweden
* Installer: optimized, correctly checks for .NET 1.1, doesn't run multiple instances, has several translations.  Rapid Fire MODIS base dataset included in install
* SVS now compatible with new server data format
* New "Flags of the World" and "County Municipalities in Norway" add-ons

1.2e (January 26, 2005)
-----------------------

* Added smooth zooming with mouse wheel.
* Added full-screen mode (Alt+Enter).
* Added "always on top" mode.
* Five add-ons created or co-created by World Wind community members--Appalachian Trail, Landmark Catalog, Norway's Prehistoric Hillforts, Tsunami Marker, and the Voyage of Ottar--are now included in the installation.
* An "Add-ons" button was added to the toolbar.
* Added "Useful Sites" menu.
* Fixed display of terrain elevation for certain locales.
* Fixed number conversion problems in Rapid Fire Modis for certain locales.
* TerrainTile files are automagically moved to the correct folder.
* Reduced number of decimals in the CoordsToClipboard function (from 9 to 5).
* Fixed GLOBE "Connection Error."
* Fixed parsing error in MODIS.
* Fixed "Copy coordinates to clipboard" giving an error.
* Fixed Pearl River display in Animated Earth.
* Changed 'Animated Earth' to 'NASA SVS'.
* A User-Agent header was added to tile requests.
* Performance enhancements, error handling enhancements, and code cleanup.
* The installer was refined, slimmed down, and converted to Nullsoft Install System.


LICENSE
=======

World Wind is licensed under the NASA Open Source Agreement. You may use, reproduce, distribute, modify, and redistribute World Wind subject to the terms of the Agreement.  For details, see the "license.txt" file that came with your copy of the software or visit http://worldwind.arc.nasa.gov/worldwind-nosa-1.3.html.


COPYRIGHT
=========

Copyright © 2004-2007 United States Government as represented by the Administrator of the National Aeronautics and Space Administration. All Rights Reserved.

Copyright © 2004-2007 Contributors. All Rights Reserved.