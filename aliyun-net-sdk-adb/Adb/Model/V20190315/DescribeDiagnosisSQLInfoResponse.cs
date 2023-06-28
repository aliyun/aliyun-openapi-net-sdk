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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeDiagnosisSQLInfoResponse : AcsResponse
	{

		private string diagnosisSQLInfo;

		private string requestId;

		private List<DescribeDiagnosisSQLInfo_StageInfosItem> stageInfos;

		public string DiagnosisSQLInfo
		{
			get
			{
				return diagnosisSQLInfo;
			}
			set	
			{
				diagnosisSQLInfo = value;
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

		public List<DescribeDiagnosisSQLInfo_StageInfosItem> StageInfos
		{
			get
			{
				return stageInfos;
			}
			set	
			{
				stageInfos = value;
			}
		}

		public class DescribeDiagnosisSQLInfo_StageInfosItem
		{

			private long? inputRows;

			private long? inputDataSize;

			private long? outputRows;

			private long? outputDataSize;

			private long? peakMemory;

			private long? operatorCost;

			private string stageId;

			private string state;

			private double? progress;

			public long? InputRows
			{
				get
				{
					return inputRows;
				}
				set	
				{
					inputRows = value;
				}
			}

			public long? InputDataSize
			{
				get
				{
					return inputDataSize;
				}
				set	
				{
					inputDataSize = value;
				}
			}

			public long? OutputRows
			{
				get
				{
					return outputRows;
				}
				set	
				{
					outputRows = value;
				}
			}

			public long? OutputDataSize
			{
				get
				{
					return outputDataSize;
				}
				set	
				{
					outputDataSize = value;
				}
			}

			public long? PeakMemory
			{
				get
				{
					return peakMemory;
				}
				set	
				{
					peakMemory = value;
				}
			}

			public long? OperatorCost
			{
				get
				{
					return operatorCost;
				}
				set	
				{
					operatorCost = value;
				}
			}

			public string StageId
			{
				get
				{
					return stageId;
				}
				set	
				{
					stageId = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public double? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}
		}
	}
}
