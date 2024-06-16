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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeUploadInfoResponse : AcsResponse
	{

		private string signature;

		private string host;

		private string requestId;

		private string policy;

		private string accessid;

		private string folder;

		private int? expire;

		public string Signature
		{
			get
			{
				return signature;
			}
			set	
			{
				signature = value;
			}
		}

		public string Host
		{
			get
			{
				return host;
			}
			set	
			{
				host = value;
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

		public string Policy
		{
			get
			{
				return policy;
			}
			set	
			{
				policy = value;
			}
		}

		public string Accessid
		{
			get
			{
				return accessid;
			}
			set	
			{
				accessid = value;
			}
		}

		public string Folder
		{
			get
			{
				return folder;
			}
			set	
			{
				folder = value;
			}
		}

		public int? Expire
		{
			get
			{
				return expire;
			}
			set	
			{
				expire = value;
			}
		}
	}
}
