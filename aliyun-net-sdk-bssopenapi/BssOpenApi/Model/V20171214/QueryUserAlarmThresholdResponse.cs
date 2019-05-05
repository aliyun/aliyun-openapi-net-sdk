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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryUserAlarmThresholdResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private int? count;

		private List<QueryUserAlarmThreshold_Data> datas;

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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public List<QueryUserAlarmThreshold_Data> Datas
		{
			get
			{
				return datas;
			}
			set	
			{
				datas = value;
			}
		}

		public class QueryUserAlarmThreshold_Data
		{

			private string thresholdAmount;

			private int? numerator;

			private int? denominator;

			private int? thresholdType;

			public string ThresholdAmount
			{
				get
				{
					return thresholdAmount;
				}
				set	
				{
					thresholdAmount = value;
				}
			}

			public int? Numerator
			{
				get
				{
					return numerator;
				}
				set	
				{
					numerator = value;
				}
			}

			public int? Denominator
			{
				get
				{
					return denominator;
				}
				set	
				{
					denominator = value;
				}
			}

			public int? ThresholdType
			{
				get
				{
					return thresholdType;
				}
				set	
				{
					thresholdType = value;
				}
			}
		}
	}
}
