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

namespace Aliyun.Acs.dt_oc_info.Model.V20220829
{
	public class GetOcIpCertificateResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcIpCertificate_DataItem> data;

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

		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
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

		public List<GetOcIpCertificate_DataItem> Data
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

		public class GetOcIpCertificate_DataItem
		{

			private string entName;

			private string certType;

			private string certNum;

			private string validStartDate;

			private string validEndDate;

			private string authorizeDate;

			private string authorizeDepartment;

			private string pubDate;

			private string province;

			private string certScope;

			public string EntName
			{
				get
				{
					return entName;
				}
				set	
				{
					entName = value;
				}
			}

			public string CertType
			{
				get
				{
					return certType;
				}
				set	
				{
					certType = value;
				}
			}

			public string CertNum
			{
				get
				{
					return certNum;
				}
				set	
				{
					certNum = value;
				}
			}

			public string ValidStartDate
			{
				get
				{
					return validStartDate;
				}
				set	
				{
					validStartDate = value;
				}
			}

			public string ValidEndDate
			{
				get
				{
					return validEndDate;
				}
				set	
				{
					validEndDate = value;
				}
			}

			public string AuthorizeDate
			{
				get
				{
					return authorizeDate;
				}
				set	
				{
					authorizeDate = value;
				}
			}

			public string AuthorizeDepartment
			{
				get
				{
					return authorizeDepartment;
				}
				set	
				{
					authorizeDepartment = value;
				}
			}

			public string PubDate
			{
				get
				{
					return pubDate;
				}
				set	
				{
					pubDate = value;
				}
			}

			public string Province
			{
				get
				{
					return province;
				}
				set	
				{
					province = value;
				}
			}

			public string CertScope
			{
				get
				{
					return certScope;
				}
				set	
				{
					certScope = value;
				}
			}
		}
	}
}
