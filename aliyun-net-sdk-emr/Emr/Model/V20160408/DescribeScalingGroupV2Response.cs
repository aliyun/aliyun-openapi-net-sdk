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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeScalingGroupV2Response : AcsResponse
	{

		private string requestId;

		private string scalingGroupId;

		private string name;

		private string description;

		private string activeStatus;

		private string hostGroupBizId;

		private string scalingInMode;

		private int? scalingMinSize;

		private int? scalingMaxSize;

		private string configState;

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

		public string ScalingGroupId
		{
			get
			{
				return scalingGroupId;
			}
			set	
			{
				scalingGroupId = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public string ActiveStatus
		{
			get
			{
				return activeStatus;
			}
			set	
			{
				activeStatus = value;
			}
		}

		public string HostGroupBizId
		{
			get
			{
				return hostGroupBizId;
			}
			set	
			{
				hostGroupBizId = value;
			}
		}

		public string ScalingInMode
		{
			get
			{
				return scalingInMode;
			}
			set	
			{
				scalingInMode = value;
			}
		}

		public int? ScalingMinSize
		{
			get
			{
				return scalingMinSize;
			}
			set	
			{
				scalingMinSize = value;
			}
		}

		public int? ScalingMaxSize
		{
			get
			{
				return scalingMaxSize;
			}
			set	
			{
				scalingMaxSize = value;
			}
		}

		public string ConfigState
		{
			get
			{
				return configState;
			}
			set	
			{
				configState = value;
			}
		}
	}
}
