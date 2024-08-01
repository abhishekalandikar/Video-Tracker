# Video-Tracker
This project is an ASP.NET MVC application that allows users to watch a YouTube video embedded on a web page. The application tracks how long users watch the video, including capturing and storing the timestamp when the video is paused or stopped. The project is designed to record analytics data, such as the duration the video was watched and the time at which it was watched.

## Features

Video Embedding: A YouTube video is embedded in the web page using YouTube's iframe API.

Custom Controls: Custom play/pause and mute/unmute controls are provided for the video.

Time Tracking: The application tracks the watched time in real-time and resumes from where the user left off.

Data Persistence: The watched time and timestamp are stored in a SQL Server database for analytics purposes.

## Getting Started

Prerequisites

Visual Studio (with ASP.NET MVC support)

SQL Server (or SQL Server Express)

Entity Framework

## Installation

1.Clone the Repository:

  git clone https://github.com/abhishekalandikar/Video-Tracker.git

2.Set Up the Database:

3.Ensure SQL Server is installed and running.

4.Update the connection string in Web.config to point to your SQL Server instance.

5.Update Database Model:
  If changes are made to the database schema, update the Entity Data Model in the project.

6.Run the Application:
  Open the solution in Visual Studio.
  
  Build and run the project using IIS Express.
  
## Usage

Access the application in your browser.

Watch the embedded video.

Play, pause, and mute/unmute the video using the provided controls.

The application will automatically save and resume from the last watched point.

## Code Structure

Controllers: Handles the main logic, including tracking video analytics.

Models: Represents the data structure, including analytics data.

Views: Contains the HTML, CSS, and JavaScript for the front-end.

Scripts: Contains custom JavaScript, including the YouTube API integration.

## Database Schema
  Analytics Table:
  
  Id (int): Primary key.
  
  VideoId (string): ID of the YouTube video.
  
  WatchedTime (float): Time watched in minutes.
  
  Timestamp (DateTime): Timestamp when the data was recorded.

