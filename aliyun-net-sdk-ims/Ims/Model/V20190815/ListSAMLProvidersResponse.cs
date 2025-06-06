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

namespace Aliyun.Acs.Ims.Model.V20190815
{
	public class ListSAMLProvidersResponse : AcsResponse
	{

		private string requestId;

		private bool? isTruncated;

		private string marker;

		private List<ListSAMLProviders_SAMLProvider> sAMLProviders;

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

		public bool? IsTruncated
		{
			get
			{
				return isTruncated;
			}
			set	
			{
				isTruncated = value;
			}
		}

		public string Marker
		{
			get
			{
				return marker;
			}
			set	
			{
				marker = value;
			}
		}

		public List<ListSAMLProviders_SAMLProvider> SAMLProviders
		{
			get
			{
				return sAMLProviders;
			}
			set	
			{
				sAMLProviders = value;
			}
		}

		public class ListSAMLProviders_SAMLProvider
		{

			private string updateDate;

			private string description;

			private string sAMLProviderName;

			private string createDate;

			private string arn;

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string SAMLProviderName
			{
				get
				{
					return sAMLProviderName;
				}
				set	
				{
					sAMLProviderName = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}

			public string Arn
			{
				get
				{
					return arn;
				}
				set	
				{
					arn = value;
				}
			}
		}
	}
}
