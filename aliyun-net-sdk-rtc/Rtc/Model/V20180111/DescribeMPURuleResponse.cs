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

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class DescribeMPURuleResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeMPURule_Rule> rules;

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

		public List<DescribeMPURule_Rule> Rules
		{
			get
			{
				return rules;
			}
			set	
			{
				rules = value;
			}
		}

		public class DescribeMPURule_Rule
		{

			private long? ruleId;

			private string channelPrefix;

			private int? mediaEncode;

			private int? backgroudColor;

			private int? cropMode;

			private string taskProfile;

			private string playDomain;

			private string callBack;

			private int? isEnable;

			private List<string> layoutIds;

			public long? RuleId
			{
				get
				{
					return ruleId;
				}
				set	
				{
					ruleId = value;
				}
			}

			public string ChannelPrefix
			{
				get
				{
					return channelPrefix;
				}
				set	
				{
					channelPrefix = value;
				}
			}

			public int? MediaEncode
			{
				get
				{
					return mediaEncode;
				}
				set	
				{
					mediaEncode = value;
				}
			}

			public int? BackgroudColor
			{
				get
				{
					return backgroudColor;
				}
				set	
				{
					backgroudColor = value;
				}
			}

			public int? CropMode
			{
				get
				{
					return cropMode;
				}
				set	
				{
					cropMode = value;
				}
			}

			public string TaskProfile
			{
				get
				{
					return taskProfile;
				}
				set	
				{
					taskProfile = value;
				}
			}

			public string PlayDomain
			{
				get
				{
					return playDomain;
				}
				set	
				{
					playDomain = value;
				}
			}

			public string CallBack
			{
				get
				{
					return callBack;
				}
				set	
				{
					callBack = value;
				}
			}

			public int? IsEnable
			{
				get
				{
					return isEnable;
				}
				set	
				{
					isEnable = value;
				}
			}

			public List<string> LayoutIds
			{
				get
				{
					return layoutIds;
				}
				set	
				{
					layoutIds = value;
				}
			}
		}
	}
}
