open System
open System.Net
open System.Windows.Forms

let displayWebPage address formText = 
    let showForm = 
        let browser = 
            let website = 
                let webClient = new WebClient()
                webClient.DownloadString(Uri address)
            new WebBrowser(ScriptErrorsSuppressed = true, 
                            Dock = DockStyle.Fill, 
                            DocumentText = website)
        let form = new Form(Text = formText)
        form.Controls.Add browser
        form.Show()
    showForm
    
displayWebPage "http://fsharp.org" "Hello from F#!"