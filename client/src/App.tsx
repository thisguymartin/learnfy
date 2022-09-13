import {
  Routes,
  Route,
} from "react-router-dom";

import Homepage from './pages/HomePage'
import LoginPage from './pages/Login'
import DetailPage from './pages/DetailPage'


import './App.css';
import axios from 'axios';

function App() {
  const [courses, setCourses] = useState([]);

  
  useEffect(() => {
    axios.get('http://localhost:5288/api/Courses').then((response) => {
      console.log(response);
      setCourses(response.data);
    });
  }, []);

  return (

    <Routes>
      <Route path="/login"><LoginPage /></Route>
      <Route path="/detail"><DetailPage /></Route>
      <Route path="/"><Homepage /></Route>
    </Routes>

  );
}

export default App;
