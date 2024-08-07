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

namespace Aliyun.Acs.quotas.Model.V20200510
{
	public class CreateQuotaApplicationsForTemplateResponse : AcsResponse
	{

		private string requestId;

		private string batchQuotaApplicationId;

		private List<CreateQuotaApplicationsForTemplate_FailResultsItem> failResults;

		private List<string> aliyunUids;

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

		public string BatchQuotaApplicationId
		{
			get
			{
				return batchQuotaApplicationId;
			}
			set	
			{
				batchQuotaApplicationId = value;
			}
		}

		public List<CreateQuotaApplicationsForTemplate_FailResultsItem> FailResults
		{
			get
			{
				return failResults;
			}
			set	
			{
				failResults = value;
			}
		}

		public List<string> AliyunUids
		{
			get
			{
				return aliyunUids;
			}
			set	
			{
				aliyunUids = value;
			}
		}

		public class CreateQuotaApplicationsForTemplate_FailResultsItem
		{

			private string aliyunUid;

			private string reason;

			public string AliyunUid
			{
				get
				{
					return aliyunUid;
				}
				set	
				{
					aliyunUid = value;
				}
			}

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}
		}
	}
}
