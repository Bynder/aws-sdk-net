/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFleet operation.
    /// Deletes everything related to a fleet. Before deleting a fleet, you must set the fleet's
    /// desired capacity to zero. See <a>UpdateFleetCapacity</a>.
    /// 
    ///  
    /// <para>
    /// This action removes the fleet's resources and the fleet record. Once a fleet is deleted,
    /// you can no longer use that fleet.
    /// </para>
    /// </summary>
    public partial class DeleteFleetRequest : AmazonGameLiftRequest
    {
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet to be deleted.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

    }
}