using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace HW4_List
{

    // a class to represent a programming language
    public class Language
    {
        public string Name { get; set; }          // name of the programming language
        public string ReleaseDate { get; set; }   // initial release date of the language
        public string Description { get; set; }   // short decription of the language
        public string IconURL { get; set; }       // language's logo
        public string ExampleURL { get; set; }    // image of example code 
    }

    public class MainViewModel
    {
        // collection to hold the Language(s)
        // the ItemSource for the HomePage ListView
        public static ObservableCollection<Language> LanguageList { get; set; } = new ObservableCollection<Language>        
        {
            // add a new Language to the LanguageList
            // one Language has been created for each letter in a-z  
            new Language
            {
                Name = "Action!",
                ReleaseDate = "1983",
                Description = "Action! is a procedural programming language similar to ALGOL that is intended to produce high-performance programs for the Atari 8-bit family. " +
                              "The language was written by Clinton Parker and distributed on ROM cartridge by Optimized Systems Software (OSS) starting in 1983. It was one of " +
                              "the first of OSS's bank switching 'Super Cartridges', with a total of 16 kB of code. Working with Henry Baker, Parker had previously developed " +
                              "Micro - SPL, a systems programming language for the Xerox Alto.Action! was largely a port of Micro - SPL concepts to the Atari with the necessary " +
                              "changes to more directly handle the underlying MOS 6502 processor and add an editor and debugger.Action! was used to develop at least two commercial " +
                              "products—the HomePak productivity suite and Games Computers Play client program—and numerous programs in ANALOG Computing and Antic magazines.The " +
                              "editor portion was also used as the basis for the PaperClip word processor.The language was not ported to any other platforms. The 6502 assembly " +
                              "language source code for Action! was made available under the GNU General Public License by the author in 2015.",
                IconURL = "action.png",
                ExampleURL = "action_example.png"
            },

            new Language
            {
                Name = "BASIC (Beginners' All-purpose Symbolic Instruction Code)",
                ReleaseDate = "1964",
                Description = "BASIC (Beginners' All-purpose Symbolic Instruction Code) is a family of general-purpose, high-level programming languages whose design philosophy " +
                              "emphasizes ease of use. The original version was designed by John G. Kemeny and Thomas E. Kurtz and released at Dartmouth College in 1964. They wanted " +
                              "to enable students in fields other than science and mathematics to use computers. At the time, nearly all use of computers required writing custom software," +
                              "which was something only scientists and mathematicians tended to learn. BASIC fell from use during the later 1980s as newer machines with far greater " +
                              "capabilities came to market and other programming languages (such as Pascal and C) became tenable. In 1991, Microsoft released Visual Basic, combining a " +
                              "greatly updated version of BASIC with a visual forms builder. This reignited use of the language and VB remains a major programming language in the form " +
                              "of VB.NET.",
                IconURL = "basic.png",
                ExampleURL = "basic_example.png"
            },

            new Language
            {
                Name = "C# (C-Sharp)",
                ReleaseDate = "2000",
                Description = "C# is a general-purpose, multi-paradigm programming language encompassing strong typing, lexically scoped, imperative, declarative, functional, generic," +
                              "object-oriented (class-based), and component-oriented programming disciplines. It was developed around 2000 by Microsoft as part of its .NET initiative, and " +
                              "later approved as an international standard by Ecma (ECMA-334) and ISO (ISO/IEC 23270:2018). C# is one of the programming languages designed for the Common " +
                              "Language Infrastructure (CLI). The language is intended to be a simple, modern, general-purpose, object-oriented programming language. The language, and " +
                              "implementations there of, should provide support for software engineering principles such as strong type checking, array bounds checking, detection of " +
                              "attempts to use uninitialized variables, and automatic garbage collection. Software robustness, durability, and programmer productivity are important. " +
                              "The language is intended for use in developing software components suitable for deployment in distributed environments. Portability is very important for " +
                              "source code and programmers, especially those already familiar with C and C++. Support for internationalization is very important. C# is intended to be " +
                              "suitable for writing applications for both hosted and embedded systems, ranging from the very large that use sophisticated operating systems, down to the " +
                              "very small having dedicated functions. Although C# applications are intended to be economical with regard to memory and processing power requirements, the " +
                              "language was not intended to compete directly on performance and size with C or assembly language",
                IconURL = "csharp.png",
                ExampleURL = "csharp_example.png "
            },

            new Language
            {
                Name = "Dart",
                ReleaseDate = "2011",
                Description = "Dart is a client-optimized programming language for apps on multiple platforms. It is developed by Google and is used to build mobile, desktop, server, " +
                              "and web applications. Dart is an object-oriented, class-based, garbage-collected language with C-style syntax. Dart can compile to either native code " +
                              "or JavaScript. It supports interfaces, mixins, abstract classes, reified generics, and type inference. Recently release Dart 2.6 is accompanied with a " +
                              "new extension dart2native. The feature extends native compilation to the Linux, macOS, and Windows desktop platforms. Earlier developers were able to create " +
                              "new tools only using Android or iOS devices. Moreover, with this extension it becomes possible to compose a Dart program into self-contained executables. Thus, " +
                              "according to the company representatives, it’s not obligatory now to have Dart SDK installed, the self-contained executables can now start running in a few " +
                              "seconds. The new extension is also integrated with Flutter toolkit, thus making it possible to use the compiler on small services (backend supporting for example).",
                IconURL = "dart.png",
                ExampleURL = "dart_example.png"
            },

            new Language
            {
                Name = "Erlang",
                ReleaseDate = "1986",
                Description = "Erlang is a general-purpose, concurrent, functional programming language, and a garbage-collected runtime system. The term Erlang is used interchangeably " +
                              "with Erlang/OTP, or Open Telecom Platform (OTP), which consists of the Erlang runtime system, several ready-to-use components (OTP) mainly written in " +
                              "Erlang, and a set of design principles for Erlang programs. Erlang was designed with the aim of improving the development of telephony applications. " +
                              "The initial version of Erlang was implemented in Prolog and was influenced by the programming language PLEX used in earlier Ericsson exchanges. The Erlang " +
                              "runtime system is designed for systems with these traits: Distributed, Fault-tolerant, Soft real-time, Highly available non-stop applications, Hot swapping, " +
                              "where code can be changed without stopping a system. The Erlang programming language has immutable data, pattern matching, and functional programming. The " +
                              "sequential subset of the Erlang language supports eager evaluation, single assignment, and dynamic typing. It was originally proprietary software within " +
                              "Ericsson, developed by Joe Armstrong, Robert Virding, and Mike Williams in 1986, but was released as free and open-source software in 1998. Erlang/OTP is " +
                              "supported and maintained by the Open Telecom Platform(OTP) product unit at Ericsson.",
                IconURL = "erlang.png",
                ExampleURL = "erlang_example.png"
            },

            new Language
            {
                Name = "F# (F-sharp)",
                ReleaseDate = "1969",
                Description = "F# is a general purpose, strongly typed, multi-paradigm programming language that encompasses functional, imperative, and object-oriented programming methods." +
                              "F# is most often used as a cross-platform Common Language Infrastructure (CLI) language, but it can also generate JavaScript and graphics processing unit (GPU)" +
                              "code. F# is developed by the F# Software Foundation, Microsoft and open contributors. An open source, cross-platform compiler for F# is available from the F# " +
                              "Software Foundation. F# is also a fully supported language in Visual Studio and Xamarin Studio. F# is a member of the ML language family and originated as " +
                              "a .NET Framework implementation of a core of the programming language OCaml. It has also been influenced by C#, Python, Haskell, Scala, and Erlang. The " +
                              "programmer does not need to declare types in F# — the compiler deduces types during compilation (type inference). F# also allows explicit type annotations, " +
                              "and requires them in some situations.",
                IconURL = "fsharp.png",
                ExampleURL = "fsharp_example.png"
            },

            new Language
            {
                Name = "GO",
                ReleaseDate = "2009",
                Description = "Go (incorrectly known as Golang) is a statically typed, compiled programming language designed at Google by Robert Griesemer, Rob Pike, and Ken Thompson. Go is " +
                              "syntactically similar to C, but with memory safety, garbage collection, structural typing, and CSP-style concurrency. There are two major implementations: Google's " +
                              "self-hosting compiler toolchain targeting multiple operating systems, mobile devices, and WebAssembly.gccgo, a GCC frontend. A third-party transpiler GopherJS " +
                              "compiles Go to JavaScript for front-end web development.",
                IconURL = "go.png",
                ExampleURL = "go_example.png"
            },

            new Language
            {
                Name = "Haskell",
                ReleaseDate = "1990",
                Description = "Haskell is a general-purpose, statically typed, purely functional programming language with type inference and lazy evaluation. Developed to be suitable for " +
                              "teaching, research and industrial application, Haskell has pioneered a number of advanced programming language features. Type classes, for example, enable " +
                              "type-safe operator overloading, were first proposed by Philip Wadler and Stephen Blott for Standard ML and were first implemented in Haskell. Haskell's main " +
                              "implementation is the Glasgow Haskell Compiler. It is named after logician Haskell Curry. Haskell's semantics are historically based on those of the Miranda " +
                              "programming language, which served to focus the efforts of the initial Haskell working group. The last formal specification of the language was made in July 2010, " +
                              "while the development of GHC's implementation has continued to extend Haskell via language extensions.The next formal specification is planned for 2020. Haskell " +
                              "is used in academia and industry. As of September 2019, Haskell was the 23rd most popular programming language in terms of Google searches for tutorials and made " +
                              "up less than 1% of active users on the GitHub source code repository.",
                IconURL = "haskell.png",
                ExampleURL = "haskell_example.png "
            },

            new Language
            {
                Name = "Idris",
                ReleaseDate = "2007",
                Description = "Idris is a purely functional programming language with dependent types, optional lazy evaluation, and features such as a totality checker. Idris may be used as a " +
                              "proof assistant, but it is designed to be a general-purpose programming language similar to Haskell. The Idris type system is similar to Agda, and proofs are similar " +
                              "to Coq, including tactics.Compared to Agda and Coq, Idris prioritizes management of side effects and support for embedded domain-specific languages. Idris compiles " +
                              "to C (relying on a custom copying garbage collector using Cheney's algorithm) and JavaScript (both browser and Node.js-based). There are third-party code generators " +
                              "for other platforms, including JVM, CIL, and LLVM. Idris is named after a singing dragon from the 1970s UK children's television program Ivor the Engine.",
                IconURL = "idris.png",
                ExampleURL = "idris_example.png"
            },

            new Language
            {
                Name = "JavaScript",
                ReleaseDate = "1995",
                Description = "JavaScript (JS) is high-level, often just-in-time compiled, and multi-paradigm. It has curly-bracket syntax, dynamic typing, prototype-based object-orientation, and " +
                              "first-class functions. Alongside HTML and CSS, JavaScript is one of the core technologies of the World Wide Web. JavaScript enables interactive web pages and is an " +
                              "essential part of web applications. The vast majority of websites use it for client-side page behavior, and all major web browsers have a dedicated JavaScript engine " +
                              "to execute it. As a multi-paradigm language, JavaScript supports event-driven, functional, and imperative programming styles. It has application programming interfaces " +
                              "(APIs) for working with text, dates, regular expressions, standard data structures, and the Document Object Model(DOM). However, the language itself does not include " +
                              "any input/output(I/O), such as networking, storage, or graphics facilities, as the host environment(usually a web browser) provides those APIs. Originally used only in " +
                              "web browsers, JavaScript engines are also now embedded in server-side website deployments and non-browser applications. Although there are similarities between JavaScript " +
                              "and Java, including language name, syntax, and respective standard libraries, the two languages are distinct and differ greatly in design.",
                IconURL = "javascript.png",
                ExampleURL = "javascript_example.png"
            },

            new Language
            {
                Name = "Kotlin",
                ReleaseDate = "2011",
                Description = "Kotlin is a cross-platform, statically typed, general-purpose programming language with type inference. Kotlin is designed to interoperate fully with Java, and the JVM " +
                              "version of its standard library depends on the Java Class Library, but type inference allows its syntax to be more concise. Kotlin mainly targets the JVM, but also compiles " +
                              "to JavaScript or native code (via LLVM). Language development costs are borne by JetBrains, while the Kotlin Foundation protects the Kotlin trademark. On 7 May 2019, Google " +
                              "announced that the Kotlin programming language is now its preferred language for Android app developers. Since the release of Android Studio 3.0 in October 2017, Kotlin has " +
                              "been included as an alternative to the standard Java compiler.The Android Kotlin compiler lets the user choose between targeting Java 6 or Java 8 compatible bytecode. The " +
                              "name comes from Kotlin Island, near St. Petersburg",
                IconURL = "kotlin.png",
                ExampleURL = "kotlin_example.png"
            },

            new Language
            {
                Name = "Lisp",
                ReleaseDate = "1958",
                Description = "Lisp (historically LISP) is a family of computer programming languages with a long history and a distinctive, fully parenthesized prefix notation. Originally specified in 1958, " +
                              "Lisp is the second-oldest high-level programming language in widespread use today. Fortran is older only by one year. Lisp has changed since its early days, and many dialects have " +
                              "existed over its history. Today, the best-known general-purpose Lisp dialects are Clojure, Common Lisp, and Scheme. Lisp was originally created as a practical mathematical notation " +
                              "for computer programs, influenced by the notation of Alonzo Church's lambda calculus. It quickly became the favored programming language for artificial intelligence research. As one " +
                              "of the earliest programming languages, Lisp pioneered many ideas in computer science, including tree data structures, automatic storage management, dynamic typing, conditionals, " +
                              "higher-order functions, recursion, the self-hosting compiler, and the read–eval–print loop. The name LISP derives from 'LISt Processor. Linked lists are one of Lisp's major data " +
                              "structures, and Lisp source code is made of lists. Thus, Lisp programs can manipulate source code as a data structure, giving rise to the macro systems that allow programmers to create " +
                              "new syntax or new domain-specific languages embedded in Lisp.",
                IconURL = "lisp.png",
                ExampleURL = "lisp_example.png"
            },

            new Language
            {
                Name = "MATLAB (Matrix Laboratory)",
                ReleaseDate = "1984",
                Description = "MATLAB is a multi-paradigm numerical computing environment and proprietary programming language developed by MathWorks. MATLAB allows matrix manipulations, plotting of functions and data, " +
                              "implementation of algorithms, creation of user interfaces, and interfacing with programs written in other languages. Although MATLAB is intended primarily for numerical computing, an " +
                              "optional toolbox uses the MuPAD symbolic engine allowing access to symbolic computing abilities. An additional package, Simulink, adds graphical multi-domain simulation and model-based " +
                              "design for dynamic and embedded systems. As of 2018, MATLAB has more than 3 million users worldwide. MATLAB users come from various backgrounds of engineering, science, and economics.",
                IconURL = "matlab.png",
                ExampleURL = "matlab_example.png"
            },

            new Language
            {
                Name = "newLISP",
                ReleaseDate = "1991",
                Description = "newLISP design is influenced by the two main Lisp dialects, Common Lisp and Scheme, and by other languages like Pascal and C. newLISP originated in 1991 and was originally developed on " +
                              "a Sun-4 workstation. It later moved to Windows 3.0, where version 1.3 was released on CompuServe around 1993, then became available as a Windows graphical user interface (GUI) " +
                              "graphics-capable application and a DOS console application (both 16-bit). In 1995, with the release of Windows 95, newLISP moved to 32-bit. In April 1999, newLISP was ported to Linux; " +
                              "some of its core algorithms were rewritten, and all Windows-specific code removed. newLISP was released as an open-source software project licensed under the GPL, and development on " +
                              "Windows stopped after version 6.0.25. During the first half of 2001, newLISP was ported back to Windows on the Cygwin platform without graphics abilities.In the second half of 2001, " +
                              "a cross-platform Tcl/Tk frontend named newLISP-tk was released around version 6.3.0. In 2006, 64-bit precision was introduced for integer arithmetic and for some operations on files " +
                              "in version 9.0. Since the release of 6.5 in mid-2002, development has been very active, and many new features have been added.",
                IconURL = "newlisp.png",
                ExampleURL = "newlisp_example.png "
            },

            new Language
            {
                Name = "OCaml",
                ReleaseDate = "1996",
                Description = "OCaml (formerly Objective Caml) is a general-purpose, multi-paradigm programming language which extends the Caml dialect of ML with object-oriented features. OCaml was created in 1996 " +
                              "by Xavier Leroy, Jérôme Vouillon, Damien Doligez, Didier Rémy, Ascánder Suárez, and others. The OCaml toolchain includes an interactive top-level interpreter, a bytecode compiler, an " +
                              "optimizing native code compiler, a reversible debugger, and a package manager(OPAM). OCaml was initially developed in the context of automated theorem proving, and has an outsize presence " +
                              "in static analysis and formal methods software. But it has found serious use beyond these areas, with major applications in systems programming, web development, and financial engineering, " +
                              "among other application domains. The acronym CAML originally stood for Categorical Abstract Machine Language, but OCaml omits this abstract machine. OCaml is a free and open-source software " +
                              "project managed and principally maintained by the French Institute for Research in Computer Science and Automation(INRIA). In the early 2000s, elements from OCaml were adopted by many languages, " +
                              "notably F# and Scala.",
                IconURL = "ocaml.png",
                ExampleURL = "ocaml_example.png"
            },

            new Language
            {
                Name = "Python",
                ReleaseDate = "1991",
                Description = "Python is an interpreted, high-level, general-purpose programming language. Created by Guido van Rossum and first released in 1991, Python's design philosophy emphasizes code readability with " +
                              "its notable use of significant whitespace. Its language constructs and object-oriented approach aim to help programmers write clear, logical code for small and large-scale projects. Python is " +
                              "dynamically typed and garbage-collected. It supports multiple programming paradigms, including procedural, object-oriented, and functional programming. Python is often described as a " +
                              "'batteries included' language due to its comprehensive standard library. Python was conceived in the late 1980s as a successor to the ABC language. Python 2.0, released in 2000, introduced features " +
                              "like list comprehensions and a garbage collection system capable of collecting reference cycles. Python 3.0, released in 2008, was a major revision of the language that is not completely " +
                              "backward-compatible, and much Python 2 code does not run unmodified on Python 3. The Python 2 language, i.e.Python 2.7.x, was officially discontinued on 1 January 2020 (first planned for 2015) " +
                              "after which security patches and other improvements will not be released for it. With Python 2's end-of-life, only Python 3.5.x and later are supported. Python interpreters are available for many " +
                              "operating systems. A global community of programmers develops and maintains CPython, an open source reference implementation. A non-profit organization, the Python Software Foundation, manages and " +
                              "directs resources for Python and CPython development.",
                IconURL = "python.png",
                ExampleURL = "python_example.png"
            },

            new Language
            {
                Name = ".QL",
                ReleaseDate = "2007",
                Description = ".QL is an object-oriented query language used to retrieve data from relational database management systems. It is reminiscent of the standard query language SQL and the object-oriented programming " +
                              "language Java. .QL is an object-oriented variant of a logical query language called Datalog. Hierarchical data can therefore be naturally queried in .QL in a recursive manner. Queries written in " +
                              ".QL are optimised, compiled into SQL and can then be executed on any major relational database management system. .QL query language is being used in SemmleCode to query a relational representation " +
                              "of Java programs. .QL is developed at Semmle Limited and is based on the company's proprietary technology.",
                IconURL = "ql.png",
                ExampleURL = "ql_example.png"
            },

            new Language
            {
                Name = "R",
                ReleaseDate = "1993",
                Description = "R is a programming language and free software environment for statistical computing and graphics supported by the R Foundation for Statistical Computing. The R language is widely used among " +
                              "statisticians and data miners for developing statistical software and data analysis. Polls, data mining surveys, and studies of scholarly literature databases show substantial increases in " +
                              "popularity; as of February 2020, R ranks 13th in the TIOBE index, a measure of popularity of programming languages. A GNU package, source code for the R software environment is written primarily " +
                              "in C, Fortran, and R itself and is freely available under the GNU General Public License. Pre-compiled binary versions are provided for various operating systems. Although R has a command line " +
                              "interface, there are several third-party graphical user interfaces, such as RStudio, an integrated development environment, and Jupyter, a notebook interface. R is an implementation of the S " +
                              "programming language combined with lexical scoping semantics, inspired by Scheme. There are some important differences, but much of the code written for S runs unaltered.",
                IconURL = "r.png",
                ExampleURL = "r_example.png"
            },

            new Language
            {
                Name = "Swift",
                ReleaseDate = "2014",
                Description = "Swift is a general-purpose, multi-paradigm, compiled programming language developed by Apple Inc. for iOS, iPadOS, macOS, watchOS, tvOS, Linux, and z/OS. Swift is designed to work with Apple's " +
                              "Cocoa and Cocoa Touch frameworks and the large body of existing Objective-C code written for Apple products. It is built with the open source LLVM compiler framework and has been included in Xcode " +
                              "since version 6, released in 2014. On Apple platforms, it uses the Objective-C runtime library which allows C, Objective-C, C++ and Swift code to run within one program. Apple intended Swift to " +
                              "support many core concepts associated with Objective-C, notably dynamic dispatch, widespread late binding, extensible programming and similar features, but in a 'safer' way, making it easier to " +
                              "catch software bugs; Swift has features addressing some common programming errors like null pointer dereferencing and provides syntactic sugar to help avoid the pyramid of doom. Swift supports the " +
                              "concept of protocol extensibility, an extensibility system that can be applied to types, structs and classes, which Apple promotes as a real change in programming paradigms they term " +
                              "'protocol-oriented programming'(similar to traits).",
                IconURL = "swift.png",
                ExampleURL = "swift_example.png"
            },

            new Language
            {
                Name = "TypeScript",
                ReleaseDate = "2012",
                Description = "TypeScript is an open-source programming language developed and maintained by Microsoft. It is a strict syntactical superset of JavaScript, and adds optional static typing to the language. TypeScript " +
                              "is designed for development of large applications and transcompiles to JavaScript. As TypeScript is a superset of JavaScript, existing JavaScript programs are also valid TypeScript programs. TypeScript " +
                              "may be used to develop JavaScript applications for both client-side and server-side execution (as with Node.js or Deno). There are multiple options available for transcompilation. Either the default " +
                              "TypeScript Checker can be used, or the Babel compiler can be invoked to convert TypeScript to JavaScript. TypeScript supports definition files that can contain type information of existing JavaScript " +
                              "libraries, much like C++ header files can describe the structure of existing object files. This enables other programs to use the values defined in the files as if they were statically typed TypeScript " +
                              "entities.There are third-party header files for popular libraries such as jQuery, MongoDB, and D3.js. TypeScript headers for the Node.js basic modules are also available, allowing development of Node.js " +
                              "programs within TypeScript.",
                IconURL = "typescript.png",
                ExampleURL = "typescript_example.png"
            },

            new Language
            {
                Name = "Umple",
                ReleaseDate = "2008",
                Description = "Umple is a language for both object-oriented programming and modelling with class diagrams and state diagrams. The name Umple is a portmanteau of 'UML', 'ample' and 'Simple', indicating that it is designed " +
                              "to provide ample features to extend programming languages with UML capabilities. he design of Umple started in 2008 at the University of Ottawa. Umple was open-sourced and its development was moved to Google " +
                              "Code in early 2011 and to GitHub in 2015. Umple was developed, in part, to address certain problems observed in the modelling community. Most specifically, it was designed to bring modelling and programming " +
                              "into alignment, help overcome inhibitions against modelling common in the programmer community, and reduce some of the difficulties of model-driven development that arise from the need to use large, expensive " +
                              "or incomplete tools. One design objective is to enable programmers to model in a way they see as natural, by adding modelling constructs to programming languages.",
                IconURL = "umple.png",
                ExampleURL = "umple_example.png"
            },

            new Language
            {
                Name = "Visual Basic",
                ReleaseDate = "2002",
                Description = "Visual Basic is a third-generation event-driven programming language from Microsoft for its Component Object Model (COM) programming model first released in 1991 and declared legacy during 2008. Microsoft " +
                              "intended Visual Basic to be relatively easy to learn and use. Visual Basic was derived from BASIC and enables the rapid application development (RAD) of graphical user interface (GUI) applications, access to " +
                              "databases using Data Access Objects, Remote Data Objects, or ActiveX Data Objects, and creation of ActiveX controls and objects. A programmer can create an application using the components provided by the " +
                              "Visual Basic program itself. Over time the community of programmers developed third-party components. Programs written in Visual Basic can also use the Windows API, which requires external function declarations. " +
                              "The final release was version 6 in 1998 (now known simply as Visual Basic). On April 8, 2008, Microsoft stopped supporting Visual Basic 6.0 IDE. The Microsoft Visual Basic team still maintains compatibility for " +
                              "Visual Basic 6.0 applications on Windows Vista, Windows Server 2008 including R2, Windows 7, Windows 8, Windows 8.1, Windows Server 2012, Windows 10, Windows Server 2016, and Windows Server 2019 through its " +
                              "'It Just Works' program. In 2014, some software developers still preferred Visual Basic 6.0 over its successor, Visual Basic.NET, and lobbied for a new version of the VB6 programming environment. In 2016, " +
                              "Visual Basic 6.0 won the technical impact award at The 19th Annual D.I.C.E.Awards. A dialect of Visual Basic, Visual Basic for Applications(VBA), is used as a macro or scripting language within several Microsoft " +
                              "applications, including Microsoft Office.",
                IconURL = "visualbasic.png",
                ExampleURL = "visualbasic_example.png "
            },

            new Language
            {
                Name = "Wolfram Language",
                ReleaseDate = "1988",
                Description = "The 'Wolfram Language' is a general multi-paradigm computational language developed by Wolfram Research and is the programming language of the mathematical symbolic computation program Mathematica and the Wolfram " +
                              "Programming Cloud. It emphasizes symbolic computation, functional programming, and rule-based programming[7] and can employ arbitrary structures and data. It includes built-in functions for generating and running " +
                              "Turing machines, creating graphics and audio, analyzing 3D models, matrix manipulations, and solving differential equations.It is extensively documented. Wolfram Language's core principles that differentiate it from " +
                              "other programming languages includes a built-in knowledgebase, automation in the form of meta-algorithms and superfunctions, a coherently elegant design and structure, built-in natural language understanding, and " +
                              "representation of everything as a symbolic expression. The Wolfram Language was released for the Raspberry Pi in 2013 with the goal of making it free for all Raspberry Pi users. It was included in the recommended " +
                              "software bundle that the Raspberry Pi Foundation provides for beginners, which caused some controversy due to the Wolfram language's proprietary nature. Plans to port the Wolfram language to the Intel Edison were " +
                              "announced after the board's introduction at CES 2014. In 2019, a link was added to make Wolfram libraries compatible with the Unity game engine, giving game developers access to the language's high level functions. " +
                              "The language was officially named in June 2013 although, as the backend of the computing system Mathematica, it has been in use in various forms for over 30 years since Mathematica's initial release. Before 2013, it " +
                              "was internally referred to by several names, such as 'M' and 'Wolfram Language.' Other possible names Wolfram Research considered include 'Lingua' and 'Express.'",
                IconURL = "wolfram.png",
                ExampleURL = "wolfram_example.png"
            },

            new Language
            {
                Name = "XOD",
                ReleaseDate = "2016",
                Description = "XOD is an open-source visual programming language for microcontrollers started in 2016. As a supported platform XOD started with Arduino boards compatibility and Raspberry PI. The basic elements of XOD programming " +
                              "are nodes. XOD is based on functional reactive principles and provides graphical flow-based programming interface. XOD can compile a native code for the low-ended controllers. A node is a block that represents either " +
                              "some physical device like a sensor, motor, or relay, or some operation such as addition, comparison, or text concatenation. XOD is also able to let the user build up some missing node using other nodes, without switching " +
                              "to textual programming.",
                IconURL = "xod.png",
                ExampleURL = "xod_example.png"
            },

            new Language
            {
                Name = "YQL",
                ReleaseDate = "2008",
                Description = "Yahoo! Query Language (YQL) is an SQL-like query language created by Yahoo! as part of their Developer Network. YQL is designed to retrieve and manipulate data from APIs through a single Web interface, thus allowing mashups " +
                              "that enable developers to create their own applications. Initially launched in October 2008 with access to Yahoo APIs, February 2009 saw the addition of open data tables from third parties such as Google Reader, the Guardian, " +
                              "and The New York Times. Some of these APIs still require an API key to access them.On April 29 of 2009, Yahoo introduced the capability to execute the tables of data built through YQL using JavaScript run on the company's " +
                              "servers for free. On January 3, 2019 Yahoo retired the YQL API service.",
                IconURL = "yql.png",
                ExampleURL = "yql_example.png"
            },

            new Language
            {
                Name = "ZOPL",
                ReleaseDate = "1979",
                Description = "ZOPL is a programming language created by Geac Computer Corporation in the early 1970s for use on their mainframe computer systems used in libraries and banking institutions. It had similarities to C and Pascal. ZOPL stood for " +
                              "'Version Z, Our Programming Language'. ZOPL is still in use at CGI Group(formerly known as RealTime Datapro), who ported it to VAX / VMS and Unix in the 1980s, and to Windows in 1998. It runs on Windows XP / 2000 / 2003 and Red " +
                              "Hat Linux. The RTM(formerly ZUG) language compiler and runtime framework are written in ZOPL. Outside of CGI, ZOPL has not been in general use since the late 1980s, although there is still one known working system where it is " +
                              "found embedded in programs written in the KARL programming language.",
                IconURL = "zopl.png",
                ExampleURL = "zopl_example.png"
            }
        }; // end of LanguageList    

    }
}
