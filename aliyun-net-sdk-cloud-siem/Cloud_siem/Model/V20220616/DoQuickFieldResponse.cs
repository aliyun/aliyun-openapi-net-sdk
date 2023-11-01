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
	public class DoQuickFieldResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string errCode;

		private string requestId;

		private string dyCode;

		private string dyMessage;

		private DoQuickField_Data data;

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

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
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

		public string DyCode
		{
			get
			{
				return dyCode;
			}
			set	
			{
				dyCode = value;
			}
		}

		public string DyMessage
		{
			get
			{
				return dyMessage;
			}
			set	
			{
				dyMessage = value;
			}
		}

		public DoQuickField_Data Data
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

		public class DoQuickField_Data
		{

			private int? queryMode;

			private long? limited;

			private int? count;

			private bool? hasSQL;

			private string whereQuery;

			private string pQuery;

			private long? processedRows;

			private bool? completeOrNot;

			private string aggQueryd;

			private List<string> keys;

			private List<string> logs;

			public int? QueryMode
			{
				get
				{
					return queryMode;
				}
				set	
				{
					queryMode = value;
				}
			}

			public long? Limited
			{
				get
				{
					return limited;
				}
				set	
				{
					limited = value;
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

			public bool? HasSQL
			{
				get
				{
					return hasSQL;
				}
				set	
				{
					hasSQL = value;
				}
			}

			public string WhereQuery
			{
				get
				{
					return whereQuery;
				}
				set	
				{
					whereQuery = value;
				}
			}

			public string PQuery
			{
				get
				{
					return pQuery;
				}
				set	
				{
					pQuery = value;
				}
			}

			public long? ProcessedRows
			{
				get
				{
					return processedRows;
				}
				set	
				{
					processedRows = value;
				}
			}

			public bool? CompleteOrNot
			{
				get
				{
					return completeOrNot;
				}
				set	
				{
					completeOrNot = value;
				}
			}

			public string AggQueryd
			{
				get
				{
					return aggQueryd;
				}
				set	
				{
					aggQueryd = value;
				}
			}

			public List<string> Keys
			{
				get
				{
					return keys;
				}
				set	
				{
					keys = value;
				}
			}

			public List<string> Logs
			{
				get
				{
					return logs;
				}
				set	
				{
					logs = value;
				}
			}
		}
	}
}
