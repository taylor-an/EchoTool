﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EchoToolCMD.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EchoTool.Resources.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Port already in use.
        /// </summary>
        internal static string AddressAlreadyInUse {
            get {
                return ResourceManager.GetString("AddressAlreadyInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not connect to server.
        /// </summary>
        internal static string CanNotConnectToServer {
            get {
                return ResourceManager.GetString("CanNotConnectToServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reply from {0}, time {1} ms {2}.
        /// </summary>
        internal static string ClientResponse {
            get {
                return ResourceManager.GetString("ClientResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection closed by remote party.
        /// </summary>
        internal static string ClosedByRemoteParty {
            get {
                return ResourceManager.GetString("ClosedByRemoteParty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hostname {0} resolved as {1}.
        /// </summary>
        internal static string HostnameResolved {
            get {
                return ResourceManager.GetString("HostnameResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host not found.
        /// </summary>
        internal static string HostNotFound {
            get {
                return ResourceManager.GetString("HostNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host unreachable.
        /// </summary>
        internal static string HostUnreachable {
            get {
                return ResourceManager.GetString("HostUnreachable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CORRUPT.
        /// </summary>
        internal static string ResponseCorrupt {
            get {
                return ResourceManager.GetString("ResponseCorrupt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OK.
        /// </summary>
        internal static string ResponseOK {
            get {
                return ResourceManager.GetString("ResponseOK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Response time out.
        /// </summary>
        internal static string ResponseTimeout {
            get {
                return ResourceManager.GetString("ResponseTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server Error.
        /// </summary>
        internal static string ServerError {
            get {
                return ResourceManager.GetString("ServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Statistics: Received={0}, Corrupted={1}.
        /// </summary>
        internal static string TCPClientStatistics {
            get {
                return ResourceManager.GetString("TCPClientStatistics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for TCP connection on port {0}. Press any key to exit..
        /// </summary>
        internal static string TCPServerCaption {
            get {
                return ResourceManager.GetString("TCPServerCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client {0} accepted at {1}.
        /// </summary>
        internal static string TCPServerConnect {
            get {
                return ResourceManager.GetString("TCPServerConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} received [{1}].
        /// </summary>
        internal static string TCPServerDataReceived {
            get {
                return ResourceManager.GetString("TCPServerDataReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session closed by peer..
        /// </summary>
        internal static string TCPSessionClosedByPeer {
            get {
                return ResourceManager.GetString("TCPSessionClosedByPeer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session timeout..
        /// </summary>
        internal static string TCPSessionTimeout {
            get {
                return ResourceManager.GetString("TCPSessionTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Statistics: Received={0}, Corupted={1}, Lost={2}.
        /// </summary>
        internal static string UDPClientStatistics {
            get {
                return ResourceManager.GetString("UDPClientStatistics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for UDP conncetion on port {0}. Press any key to exit..
        /// </summary>
        internal static string UDPServerCaption {
            get {
                return ResourceManager.GetString("UDPServerCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} from {1} received [{2}].
        /// </summary>
        internal static string UDPServerDataReceived {
            get {
                return ResourceManager.GetString("UDPServerDataReceived", resourceCulture);
            }
        }
    }
}
