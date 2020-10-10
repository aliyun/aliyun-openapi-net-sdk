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

namespace Aliyun.Acs.Vcs.Model.V20200515
{
	public class GetMonitorResultResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetMonitorResult_Data data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public GetMonitorResult_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetMonitorResult_Data
		{

			private string maxId;

			private List<GetMonitorResult_RecordsItem> records;

			public string MaxId
			{
				get
				{
					return maxId;
				}
				set	
				{
					maxId = value;
				}
			}

			public List<GetMonitorResult_RecordsItem> Records
			{
				get
				{
					return records;
				}
				set	
				{
					records = value;
				}
			}

			public class GetMonitorResult_RecordsItem
			{

				private string rightBottomY;

				private string rightBottomX;

				private string leftUpY;

				private string leftUpX;

				private string gbId;

				private string score;

				private string picUrl;

				private string shotTime;

				private string monitorPicUrl;

				private string targetPicUrl;

				private string taskId;

				private GetMonitorResult_ExtendInfo extendInfo;

				public string RightBottomY
				{
					get
					{
						return rightBottomY;
					}
					set	
					{
						rightBottomY = value;
					}
				}

				public string RightBottomX
				{
					get
					{
						return rightBottomX;
					}
					set	
					{
						rightBottomX = value;
					}
				}

				public string LeftUpY
				{
					get
					{
						return leftUpY;
					}
					set	
					{
						leftUpY = value;
					}
				}

				public string LeftUpX
				{
					get
					{
						return leftUpX;
					}
					set	
					{
						leftUpX = value;
					}
				}

				public string GbId
				{
					get
					{
						return gbId;
					}
					set	
					{
						gbId = value;
					}
				}

				public string Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
					}
				}

				public string PicUrl
				{
					get
					{
						return picUrl;
					}
					set	
					{
						picUrl = value;
					}
				}

				public string ShotTime
				{
					get
					{
						return shotTime;
					}
					set	
					{
						shotTime = value;
					}
				}

				public string MonitorPicUrl
				{
					get
					{
						return monitorPicUrl;
					}
					set	
					{
						monitorPicUrl = value;
					}
				}

				public string TargetPicUrl
				{
					get
					{
						return targetPicUrl;
					}
					set	
					{
						targetPicUrl = value;
					}
				}

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}

				public GetMonitorResult_ExtendInfo ExtendInfo
				{
					get
					{
						return extendInfo;
					}
					set	
					{
						extendInfo = value;
					}
				}

				public class GetMonitorResult_ExtendInfo
				{

					private string plateNo;

					public string PlateNo
					{
						get
						{
							return plateNo;
						}
						set	
						{
							plateNo = value;
						}
					}
				}
			}
		}
	}
}
