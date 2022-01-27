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

namespace Aliyun.Acs.reid_cloud.Model.V20201029
{
	public class DescribeCameraStatisticsResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string message;

		private string code;

		private string dynamicCode;

		private string requestId;

		private bool? success;

		private string dynamicMessage;

		private List<DescribeCameraStatistics_PvStatisticResult> pvStatisticResults;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public List<DescribeCameraStatistics_PvStatisticResult> PvStatisticResults
		{
			get
			{
				return pvStatisticResults;
			}
			set	
			{
				pvStatisticResults = value;
			}
		}

		public class DescribeCameraStatistics_PvStatisticResult
		{

			private long? ipcId;

			private long? maxDataTime;

			private long? pvCount;

			private string pvType;

			private long? locationId;

			private List<DescribeCameraStatistics_Rect> pvRects;

			public long? IpcId
			{
				get
				{
					return ipcId;
				}
				set	
				{
					ipcId = value;
				}
			}

			public long? MaxDataTime
			{
				get
				{
					return maxDataTime;
				}
				set	
				{
					maxDataTime = value;
				}
			}

			public long? PvCount
			{
				get
				{
					return pvCount;
				}
				set	
				{
					pvCount = value;
				}
			}

			public string PvType
			{
				get
				{
					return pvType;
				}
				set	
				{
					pvType = value;
				}
			}

			public long? LocationId
			{
				get
				{
					return locationId;
				}
				set	
				{
					locationId = value;
				}
			}

			public List<DescribeCameraStatistics_Rect> PvRects
			{
				get
				{
					return pvRects;
				}
				set	
				{
					pvRects = value;
				}
			}

			public class DescribeCameraStatistics_Rect
			{

				private float? right;

				private float? left;

				private float? top;

				private float? bottom;

				public float? Right
				{
					get
					{
						return right;
					}
					set	
					{
						right = value;
					}
				}

				public float? Left
				{
					get
					{
						return left;
					}
					set	
					{
						left = value;
					}
				}

				public float? Top
				{
					get
					{
						return top;
					}
					set	
					{
						top = value;
					}
				}

				public float? Bottom
				{
					get
					{
						return bottom;
					}
					set	
					{
						bottom = value;
					}
				}
			}
		}
	}
}
