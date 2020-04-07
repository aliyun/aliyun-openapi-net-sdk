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

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
	public class GetCameraStatisticResponse : AcsResponse
	{

		private string requestId;

		private string errorMsg;

		private bool? success;

		private List<GetCameraStatistic_PvStatisticResult> pvStatisticResults;

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

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
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

		public List<GetCameraStatistic_PvStatisticResult> PvStatisticResults
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

		public class GetCameraStatistic_PvStatisticResult
		{

			private long? processCursor;

			private long? ipcId;

			private long? locationId;

			private long? pvCount;

			private List<GetCameraStatistic_Rect> pvRects;

			public long? ProcessCursor
			{
				get
				{
					return processCursor;
				}
				set	
				{
					processCursor = value;
				}
			}

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

			public List<GetCameraStatistic_Rect> PvRects
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

			public class GetCameraStatistic_Rect
			{

				private float? right;

				private float? bottom;

				private float? top;

				private float? left;

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
			}
		}
	}
}
