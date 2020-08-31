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

namespace Aliyun.Acs.Config.Model.V20190108
{
	public class DescribeDeliveryChannelsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDeliveryChannels_DeliveryChannel> deliveryChannels;

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

		public List<DescribeDeliveryChannels_DeliveryChannel> DeliveryChannels
		{
			get
			{
				return deliveryChannels;
			}
			set	
			{
				deliveryChannels = value;
			}
		}

		public class DescribeDeliveryChannels_DeliveryChannel
		{

			private string deliveryChannelId;

			private string deliveryChannelName;

			private string deliveryChannelType;

			private string deliveryChannelTargetArn;

			private string deliveryChannelAssumeRoleArn;

			private string deliveryChannelCondition;

			private string description;

			private int? status;

			public string DeliveryChannelId
			{
				get
				{
					return deliveryChannelId;
				}
				set	
				{
					deliveryChannelId = value;
				}
			}

			public string DeliveryChannelName
			{
				get
				{
					return deliveryChannelName;
				}
				set	
				{
					deliveryChannelName = value;
				}
			}

			public string DeliveryChannelType
			{
				get
				{
					return deliveryChannelType;
				}
				set	
				{
					deliveryChannelType = value;
				}
			}

			public string DeliveryChannelTargetArn
			{
				get
				{
					return deliveryChannelTargetArn;
				}
				set	
				{
					deliveryChannelTargetArn = value;
				}
			}

			public string DeliveryChannelAssumeRoleArn
			{
				get
				{
					return deliveryChannelAssumeRoleArn;
				}
				set	
				{
					deliveryChannelAssumeRoleArn = value;
				}
			}

			public string DeliveryChannelCondition
			{
				get
				{
					return deliveryChannelCondition;
				}
				set	
				{
					deliveryChannelCondition = value;
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

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}
		}
	}
}
