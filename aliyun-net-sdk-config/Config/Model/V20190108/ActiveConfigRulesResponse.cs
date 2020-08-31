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

namespace Aliyun.Acs.Config.Model.V20190108
{
	public class ActiveConfigRulesResponse : AcsResponse
	{

		private string requestId;

		private ActiveConfigRules_OperateRuleResult operateRuleResult;

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

		public ActiveConfigRules_OperateRuleResult OperateRuleResult
		{
			get
			{
				return operateRuleResult;
			}
			set	
			{
				operateRuleResult = value;
			}
		}

		public class ActiveConfigRules_OperateRuleResult
		{

			private List<ActiveConfigRules_OperateRuleItem> operateRuleItemList;

			public List<ActiveConfigRules_OperateRuleItem> OperateRuleItemList
			{
				get
				{
					return operateRuleItemList;
				}
				set	
				{
					operateRuleItemList = value;
				}
			}

			public class ActiveConfigRules_OperateRuleItem
			{

				private string configRuleId;

				private string errorCode;

				private bool? success;

				public string ConfigRuleId
				{
					get
					{
						return configRuleId;
					}
					set	
					{
						configRuleId = value;
					}
				}

				public string ErrorCode
				{
					get
					{
						return errorCode;
					}
					set	
					{
						errorCode = value;
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
			}
		}
	}
}
