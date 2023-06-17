// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
function App() {
    const [count, setCount] = React.useState(0)

    React.useEffect(() => {
        if (count < 101) {
            const interval = setInterval(() => {
                setCount(prev => prev + 1)
            }, 100000)

            return () => clearInterval(interval)
        }
    }, [count])

    return <div>
        Count: {count}
    </div>
}


const el = document.querySelector("#root");
ReactDOM.render(<App />, el);
// Write your JavaScript code.
