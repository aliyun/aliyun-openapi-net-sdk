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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryPriceEntityListResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private QueryPriceEntityList_Data data;

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

		public QueryPriceEntityList_Data Data
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

		public class QueryPriceEntityList_Data
		{

			private List<QueryPriceEntityList_PriceEntityInfoDTO> priceEntityInfoList;

			public List<QueryPriceEntityList_PriceEntityInfoDTO> PriceEntityInfoList
			{
				get
				{
					return priceEntityInfoList;
				}
				set	
				{
					priceEntityInfoList = value;
				}
			}

			public class QueryPriceEntityList_PriceEntityInfoDTO
			{

				private string priceEntityCode;

				private string priceEntityName;

				private List<QueryPriceEntityList_PriceFactorDTO> priceFactorList;

				public string PriceEntityCode
				{
					get
					{
						return priceEntityCode;
					}
					set	
					{
						priceEntityCode = value;
					}
				}

				public string PriceEntityName
				{
					get
					{
						return priceEntityName;
					}
					set	
					{
						priceEntityName = value;
					}
				}

				public List<QueryPriceEntityList_PriceFactorDTO> PriceFactorList
				{
					get
					{
						return priceFactorList;
					}
					set	
					{
						priceFactorList = value;
					}
				}

				public class QueryPriceEntityList_PriceFactorDTO
				{

					private string priceFactorCode;

					private string priceFactorName;

					private List<string> priceFactorValueList;

					public string PriceFactorCode
					{
						get
						{
							return priceFactorCode;
						}
						set	
						{
							priceFactorCode = value;
						}
					}

					public string PriceFactorName
					{
						get
						{
							return priceFactorName;
						}
						set	
						{
							priceFactorName = value;
						}
					}

					public List<string> PriceFactorValueList
					{
						get
						{
							return priceFactorValueList;
						}
						set	
						{
							priceFactorValueList = value;
						}
					}
				}
			}
		}
	}
}
