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
	public class ListSlowQueryQueriesResponse : AcsResponse
	{

		private string requestId;

		private ListSlowQueryQueries_Result result;

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

		public ListSlowQueryQueries_Result Result
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

		public class ListSlowQueryQueries_Result
		{

			private int? start;

			private int? end;

			private int? index;

			private string appQuery;

			public int? Start
			{
				get
				{
					return start;
				}
				set	
				{
					start = value;
				}
			}

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

			public int? Index
			{
				get
				{
					return index;
				}
				set	
				{
					index = value;
				}
			}

			public string AppQuery
			{
				get
				{
					return appQuery;
				}
				set	
				{
					appQuery = value;
				}
			}
		}
	}
}
