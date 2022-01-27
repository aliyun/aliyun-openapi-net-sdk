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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class ListInterventionDictionaryNerResultsResponse : AcsResponse
	{

		private string requestId;

		private List<ListInterventionDictionaryNerResults_NerItem> result;

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

		public List<ListInterventionDictionaryNerResults_NerItem> Result
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

		public class ListInterventionDictionaryNerResults_NerItem
		{

			private string tag;

			private string tagLabel;

			private string token;

			private int? order;

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public string TagLabel
			{
				get
				{
					return tagLabel;
				}
				set	
				{
					tagLabel = value;
				}
			}

			public string Token
			{
				get
				{
					return token;
				}
				set	
				{
					token = value;
				}
			}

			public int? Order
			{
				get
				{
					return order;
				}
				set	
				{
					order = value;
				}
			}
		}
	}
}
