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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeLiveStreamPushDataResponse : AcsResponse
	{

		private List<PushStreamModel> pushStreamModelList;

		public List<PushStreamModel> PushStreamModelList
		{
			get
			{
				return pushStreamModelList;
			}
			set	
			{
				pushStreamModelList = value;
			}
		}

		public class PushStreamModel{

			private string time;

			private float? frameRate;

			private float? bitRate;

			private float? frameLossRate;

			private string serverAddr;

			private string clientAddr;

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public float? FrameRate
			{
				get
				{
					return frameRate;
				}
				set	
				{
					frameRate = value;
				}
			}

			public float? BitRate
			{
				get
				{
					return bitRate;
				}
				set	
				{
					bitRate = value;
				}
			}

			public float? FrameLossRate
			{
				get
				{
					return frameLossRate;
				}
				set	
				{
					frameLossRate = value;
				}
			}

			public string ServerAddr
			{
				get
				{
					return serverAddr;
				}
				set	
				{
					serverAddr = value;
				}
			}

			public string ClientAddr
			{
				get
				{
					return clientAddr;
				}
				set	
				{
					clientAddr = value;
				}
			}
		}
	}
}