/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.ROS.Model.V20190910
{
	public class GetStackDriftDetectionStatusResponse : AcsResponse
	{

		private string requestId;

		private string driftDetectionId;

		private string driftDetectionTime;

		private string driftDetectionStatus;

		private string driftDetectionStatusReason;

		private string stackDriftStatus;

		private string stackId;

		private int? driftedStackResourceCount;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string DriftDetectionId
		{
			get
			{
				return driftDetectionId;
			}
			set	
			{
				driftDetectionId = value;
			}
		}

		public string DriftDetectionTime
		{
			get
			{
				return driftDetectionTime;
			}
			set	
			{
				driftDetectionTime = value;
			}
		}

		public string DriftDetectionStatus
		{
			get
			{
				return driftDetectionStatus;
			}
			set	
			{
				driftDetectionStatus = value;
			}
		}

		public string DriftDetectionStatusReason
		{
			get
			{
				return driftDetectionStatusReason;
			}
			set	
			{
				driftDetectionStatusReason = value;
			}
		}

		public string StackDriftStatus
		{
			get
			{
				return stackDriftStatus;
			}
			set	
			{
				stackDriftStatus = value;
			}
		}

		public string StackId
		{
			get
			{
				return stackId;
			}
			set	
			{
				stackId = value;
			}
		}

		public int? DriftedStackResourceCount
		{
			get
			{
				return driftedStackResourceCount;
			}
			set	
			{
				driftedStackResourceCount = value;
			}
		}
	}
}
