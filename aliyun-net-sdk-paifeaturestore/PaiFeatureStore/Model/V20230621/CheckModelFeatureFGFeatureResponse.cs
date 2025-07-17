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

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
	public class CheckModelFeatureFGFeatureResponse : AcsResponse
	{

		private string requestId;

		private List<CheckModelFeatureFGFeature_FGCheckResultsItem> fGCheckResults;

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

		public List<CheckModelFeatureFGFeature_FGCheckResultsItem> FGCheckResults
		{
			get
			{
				return fGCheckResults;
			}
			set	
			{
				fGCheckResults = value;
			}
		}

		public class CheckModelFeatureFGFeature_FGCheckResultsItem
		{

			private string ruleCode;

			private bool? status;

			private string message;

			public string RuleCode
			{
				get
				{
					return ruleCode;
				}
				set	
				{
					ruleCode = value;
				}
			}

			public bool? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
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
		}
	}
}
