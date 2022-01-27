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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeQuaraFileDownloadInfoResponse : AcsResponse
	{

		private string requestId;

		private int? quaraFileId;

		private string uuid;

		private string path;

		private string md5;

		private string tag;

		private string downloadUrl;

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

		public int? QuaraFileId
		{
			get
			{
				return quaraFileId;
			}
			set	
			{
				quaraFileId = value;
			}
		}

		public string Uuid
		{
			get
			{
				return uuid;
			}
			set	
			{
				uuid = value;
			}
		}

		public string Path
		{
			get
			{
				return path;
			}
			set	
			{
				path = value;
			}
		}

		public string Md5
		{
			get
			{
				return md5;
			}
			set	
			{
				md5 = value;
			}
		}

		public string Tag
		{
			get
			{
				return tag;
			}
			set	
			{
				tag = value;
			}
		}

		public string DownloadUrl
		{
			get
			{
				return downloadUrl;
			}
			set	
			{
				downloadUrl = value;
			}
		}
	}
}
