﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mundo.Resources {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Mundo.Resources.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Aceptar.
        /// </summary>
        public static string Aceptar {
            get {
                return ResourceManager.GetString("Aceptar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error.
        /// </summary>
        public static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Escribe tu contraseña.
        /// </summary>
        public static string ingresacontra {
            get {
                return ResourceManager.GetString("ingresacontra", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Escribe tu correo....
        /// </summary>
        public static string ingresaemail {
            get {
                return ResourceManager.GetString("ingresaemail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a iniciar sesión.
        /// </summary>
        public static string login {
            get {
                return ResourceManager.GetString("login", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Recorderme en este dispositivo.
        /// </summary>
        public static string recordarme {
            get {
                return ResourceManager.GetString("recordarme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Ingresa un Email.
        /// </summary>
        public static string validacionEmail {
            get {
                return ResourceManager.GetString("validacionEmail", resourceCulture);
            }
        }
    }
}
