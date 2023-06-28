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

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
	public class QueryTimeTemplateDetailResponse : AcsResponse
	{

		private string code;

		private string requestId;

		private string errorMessage;

		private bool? success;

		private QueryTimeTemplateDetail_Data data;

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

		public QueryTimeTemplateDetail_Data Data
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

		public class QueryTimeTemplateDetail_Data
		{

			private int? allDay;

			private int? _default;

			private string name;

			private string templateId;

			private List<QueryTimeTemplateDetail_TimeSectionListItem> timeSectionList;

			public int? AllDay
			{
				get
				{
					return allDay;
				}
				set	
				{
					allDay = value;
				}
			}

			public int? _Default
			{
				get
				{
					return _default;
				}
				set	
				{
					_default = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}

			public List<QueryTimeTemplateDetail_TimeSectionListItem> TimeSectionList
			{
				get
				{
					return timeSectionList;
				}
				set	
				{
					timeSectionList = value;
				}
			}

			public class QueryTimeTemplateDetail_TimeSectionListItem
			{

				private int? end;

				private int? dayOfWeek;

				private int? begin;

				public int? End
				{
					get
					{
						return end;
					}
					set	
					{
						end = value;
					}
				}

				public int? DayOfWeek
				{
					get
					{
						return dayOfWeek;
					}
					set	
					{
						dayOfWeek = value;
					}
				}

				public int? Begin
				{
					get
					{
						return begin;
					}
					set	
					{
						begin = value;
					}
				}
			}
		}
	}
}
