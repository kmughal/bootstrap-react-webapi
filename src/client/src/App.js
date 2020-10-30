
import React from "react"

const App = props => {
    const [data,setData] = React.useState([]);

    React.useEffect(() => {
        fetch("http://localhost:5000/test")
        .then(res => res.json())
        .then(setData)
        .catch(console.error);
    }, []);

    return <>
    <pre>{JSON.stringify(data)}</pre>
    <h1>Hello World</h1>
    </>
}
export default App;