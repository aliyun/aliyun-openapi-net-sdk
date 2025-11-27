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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class SmartqQueryAbilityResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private SmartqQueryAbility_Result result;

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

		public SmartqQueryAbility_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class SmartqQueryAbility_Result
		{

			private string chartType;

			private string logicSql;

			private string conclusionText;

			private List<SmartqQueryAbility_MetaTypeItem> metaType;

			private List<SmartqQueryAbility_ValuesItem> values;

			private List<string> dataList;

			public string ChartType
			{
				get
				{
					return chartType;
				}
				set	
				{
					chartType = value;
				}
			}

			public string LogicSql
			{
				get
				{
					return logicSql;
				}
				set	
				{
					logicSql = value;
				}
			}

			public string ConclusionText
			{
				get
				{
					return conclusionText;
				}
				set	
				{
					conclusionText = value;
				}
			}

			public List<SmartqQueryAbility_MetaTypeItem> MetaType
			{
				get
				{
					return metaType;
				}
				set	
				{
					metaType = value;
				}
			}

			public List<SmartqQueryAbility_ValuesItem> Values
			{
				get
				{
					return values;
				}
				set	
				{
					values = value;
				}
			}

			public List<string> DataList
			{
				get
				{
					return dataList;
				}
				set	
				{
					dataList = value;
				}
			}

			public class SmartqQueryAbility_MetaTypeItem
			{

				private string key;

				private string _value;

				private string type;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}
			}

			public class SmartqQueryAbility_ValuesItem
			{

				private List<string> row;

				public List<string> Row
				{
					get
					{
						return row;
					}
					set	
					{
						row = value;
					}
				}
			}
		}
	}
}
