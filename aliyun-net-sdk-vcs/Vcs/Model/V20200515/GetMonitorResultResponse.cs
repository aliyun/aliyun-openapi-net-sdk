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

		private string score;

		private string leftTopX;

		private string leftTopY;

		private string rightBottomX;

		private string rightBottomY;

		private List<GetMonitorResult_RecordsItem> records;

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

		public string LeftTopX
		{
			get
			{
				return leftTopX;
			}
			set	
			{
				leftTopX = value;
			}
		}

		public string LeftTopY
		{
			get
			{
				return leftTopY;
			}
			set	
			{
				leftTopY = value;
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

		public class GetMonitorResult_RecordsItem
		{

			private string gbId;

			private string shotTime;

			private string monitorPicUrl;

			private string shotPicUrl;

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

			public string ShotPicUrl
			{
				get
				{
					return shotPicUrl;
				}
				set	
				{
					shotPicUrl = value;
				}
			}
		}

		public class GetMonitorResult_Data
		{

			private string maxRecordId;

			public string MaxRecordId
			{
				get
				{
					return maxRecordId;
				}
				set	
				{
					maxRecordId = value;
				}
			}
		}
	}
}
