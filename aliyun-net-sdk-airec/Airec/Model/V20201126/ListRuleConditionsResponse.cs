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

namespace Aliyun.Acs.Airec.Model.V20201126
{
	public class ListRuleConditionsResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private List<ListRuleConditions_ResultItem> result;

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

		public List<ListRuleConditions_ResultItem> Result
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

		public class ListRuleConditions_ResultItem
		{

			private string selectType;

			private string selectValue;

			private string selectionOperation;

			public string SelectType
			{
				get
				{
					return selectType;
				}
				set	
				{
					selectType = value;
				}
			}

			public string SelectValue
			{
				get
				{
					return selectValue;
				}
				set	
				{
					selectValue = value;
				}
			}

			public string SelectionOperation
			{
				get
				{
					return selectionOperation;
				}
				set	
				{
					selectionOperation = value;
				}
			}
		}
	}
}
