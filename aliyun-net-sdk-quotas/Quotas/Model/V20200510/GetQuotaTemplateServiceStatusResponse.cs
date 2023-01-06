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
	public class GetQuotaTemplateServiceStatusResponse : AcsResponse
	{

		private string requestId;

		private GetQuotaTemplateServiceStatus_TemplateServiceStatus templateServiceStatus;

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

		public GetQuotaTemplateServiceStatus_TemplateServiceStatus TemplateServiceStatus
		{
			get
			{
				return templateServiceStatus;
			}
			set	
			{
				templateServiceStatus = value;
			}
		}

		public class GetQuotaTemplateServiceStatus_TemplateServiceStatus
		{

			private int? serviceStatus;

			private string resourceDirectoryId;

			public int? ServiceStatus
			{
				get
				{
					return serviceStatus;
				}
				set	
				{
					serviceStatus = value;
				}
			}

			public string ResourceDirectoryId
			{
				get
				{
					return resourceDirectoryId;
				}
				set	
				{
					resourceDirectoryId = value;
				}
			}
		}
	}
}
