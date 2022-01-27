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
using Newtonsoft.Json;
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

			private int? status;

			private string deliveryChannelName;

			private string deliveryChannelId;

			private string deliveryChannelType;

			private string deliveryChannelAssumeRoleArn;

			private string description;

			private string deliveryChannelCondition;

			private string deliveryChannelTargetArn;

			private bool? configurationSnapshot;

			private bool? configurationItemChangeNotification;

			private bool? nonCompliantNotification;

			private string oversizedDataOSSTargetArn;

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

			public bool? ConfigurationSnapshot
			{
				get
				{
					return configurationSnapshot;
				}
				set	
				{
					configurationSnapshot = value;
				}
			}

			public bool? ConfigurationItemChangeNotification
			{
				get
				{
					return configurationItemChangeNotification;
				}
				set	
				{
					configurationItemChangeNotification = value;
				}
			}

			public bool? NonCompliantNotification
			{
				get
				{
					return nonCompliantNotification;
				}
				set	
				{
					nonCompliantNotification = value;
				}
			}

			public string OversizedDataOSSTargetArn
			{
				get
				{
					return oversizedDataOSSTargetArn;
				}
				set	
				{
					oversizedDataOSSTargetArn = value;
				}
			}
		}
	}
}
