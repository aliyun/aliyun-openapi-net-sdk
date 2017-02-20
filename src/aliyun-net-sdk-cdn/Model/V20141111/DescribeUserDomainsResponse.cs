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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeUserDomainsResponse : AcsResponse
	{
	    public long? PageNumber { get; set; }

	    public long? PageSize { get; set; }

	    public long? TotalCount { get; set; }

	    public List<PageData> Domains { get; set; }

	    public class PageData{
	        public string DomainName { get; set; }

	        public string Cname { get; set; }

	        public string CdnType { get; set; }

	        public string DomainStatus { get; set; }

	        public string GmtCreated { get; set; }

	        public string GmtModified { get; set; }

	        public string Description { get; set; }

	        public string SourceType { get; set; }

	        public string SslProtocol { get; set; }

	        public List<string> Sources { get; set; }
	    }
	}
}