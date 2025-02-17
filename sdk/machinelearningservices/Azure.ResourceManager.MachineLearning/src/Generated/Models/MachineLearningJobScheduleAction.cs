// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningJobScheduleAction. </summary>
    public partial class MachineLearningJobScheduleAction : MachineLearningScheduleAction
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningJobScheduleAction"/>. </summary>
        /// <param name="jobDefinition">
        /// [Required] Defines Schedule action definition details.
        /// Please note <see cref="MachineLearningJobProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoMLJob"/>, <see cref="MachineLearningCommandJob"/>, <see cref="LabelingJobProperties"/>, <see cref="MachineLearningPipelineJob"/>, <see cref="SparkJob"/> and <see cref="MachineLearningSweepJob"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobDefinition"/> is null. </exception>
        public MachineLearningJobScheduleAction(MachineLearningJobProperties jobDefinition)
        {
            Argument.AssertNotNull(jobDefinition, nameof(jobDefinition));

            JobDefinition = jobDefinition;
            ActionType = ScheduleActionType.CreateJob;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningJobScheduleAction"/>. </summary>
        /// <param name="actionType"> [Required] Specifies the action type of the schedule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="jobDefinition">
        /// [Required] Defines Schedule action definition details.
        /// Please note <see cref="MachineLearningJobProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoMLJob"/>, <see cref="MachineLearningCommandJob"/>, <see cref="LabelingJobProperties"/>, <see cref="MachineLearningPipelineJob"/>, <see cref="SparkJob"/> and <see cref="MachineLearningSweepJob"/>.
        /// </param>
        internal MachineLearningJobScheduleAction(ScheduleActionType actionType, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningJobProperties jobDefinition) : base(actionType, serializedAdditionalRawData)
        {
            JobDefinition = jobDefinition;
            ActionType = actionType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningJobScheduleAction"/> for deserialization. </summary>
        internal MachineLearningJobScheduleAction()
        {
        }

        /// <summary>
        /// [Required] Defines Schedule action definition details.
        /// Please note <see cref="MachineLearningJobProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoMLJob"/>, <see cref="MachineLearningCommandJob"/>, <see cref="LabelingJobProperties"/>, <see cref="MachineLearningPipelineJob"/>, <see cref="SparkJob"/> and <see cref="MachineLearningSweepJob"/>.
        /// </summary>
        public MachineLearningJobProperties JobDefinition { get; set; }
    }
}
