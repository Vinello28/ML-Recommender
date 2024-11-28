# Recommender

Recommender developed using ML.NET Microsoft library, use machine learning algorithms to know if a comment is good or bad

## Project Description

This project is a sentiment analysis recommender system developed using the ML.NET Microsoft library. The purpose of this project is to classify comments as either good or bad based on their content. The system uses machine learning algorithms to analyze the text and predict the sentiment of the comments.

## Setup Instructions

To set up the project locally, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/Vinello28/ML-Recommender.git
   ```

2. Navigate to the project directory:
   ```bash
   cd ML-Recommender
   ```

3. Install the required dependencies:
   ```bash
   dotnet restore
   ```

4. Build the project:
   ```bash
   dotnet build
   ```

5. Run the project:
   ```bash
   dotnet run --project Prediction_engine
   ```

## Using the Recommender

To use the recommender, follow these steps:

1. Run the project using the setup instructions above.
2. Enter a comment when prompted.
3. The system will classify the comment as either "good" or "bad" based on its content.

### Example

Input: "The food was amazing and the service was excellent!"
Output: "Thats good"

Input: "The food was terrible and the service was slow."
Output: "disgusting place"

## Retraining the Model

To retrain the model with new data, follow these steps:

1. Prepare a new dataset in the same format as the existing dataset (`yelp_labelled.txt`).
2. Update the `RetrainFilePath` constant in the `MLModelSentID.training.cs` file to point to the new dataset.
3. Run the training script:
   ```bash
   dotnet run --project Prediction_engine --configuration Release -- Train
   ```

## Contributing

We welcome contributions to this project! If you would like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bugfix:
   ```bash
   git checkout -b my-feature-branch
   ```

3. Make your changes and commit them:
   ```bash
   git commit -m "Description of my changes"
   ```

4. Push your changes to your fork:
   ```bash
   git push origin my-feature-branch
   ```

5. Create a pull request from your branch to the main repository.

Thank you for your contributions!
