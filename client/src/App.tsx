import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
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
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <ul>
        {courses.map((course: any, index) => {
          return (
            <li key={index}>
              
              <div>
              <img src={course.image} height="80px"></img>


            </div>
              <p>{course.title}</p>

            </li>
          );
        })}
      </ul>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
