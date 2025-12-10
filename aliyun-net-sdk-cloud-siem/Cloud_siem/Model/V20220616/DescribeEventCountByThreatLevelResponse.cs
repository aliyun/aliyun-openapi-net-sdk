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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class DescribeEventCountByThreatLevelResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private DescribeEventCountByThreatLevel_Data data;

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

		public int? Code
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

		public DescribeEventCountByThreatLevel_Data Data
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

		public class DescribeEventCountByThreatLevel_Data
		{

			private long? eventNum;

			private long? undealEventNum;

			private long? highLevelEventNum;

			private long? mediumLevelEventNum;

			private long? lowLevelEventNum;

			private long? seriousLevelEventNum;

			private long? infoLevelEventNum;

			public long? EventNum
			{
				get
				{
					return eventNum;
				}
				set	
				{
					eventNum = value;
				}
			}

			public long? UndealEventNum
			{
				get
				{
					return undealEventNum;
				}
				set	
				{
					undealEventNum = value;
				}
			}

			public long? HighLevelEventNum
			{
				get
				{
					return highLevelEventNum;
				}
				set	
				{
					highLevelEventNum = value;
				}
			}

			public long? MediumLevelEventNum
			{
				get
				{
					return mediumLevelEventNum;
				}
				set	
				{
					mediumLevelEventNum = value;
				}
			}

			public long? LowLevelEventNum
			{
				get
				{
					return lowLevelEventNum;
				}
				set	
				{
					lowLevelEventNum = value;
				}
			}

			public long? SeriousLevelEventNum
			{
				get
				{
					return seriousLevelEventNum;
				}
				set	
				{
					seriousLevelEventNum = value;
				}
			}

			public long? InfoLevelEventNum
			{
				get
				{
					return infoLevelEventNum;
				}
				set	
				{
					infoLevelEventNum = value;
				}
			}
		}
	}
}
