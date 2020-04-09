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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeMongoDBLogConfigResponse : AcsResponse
	{

		private string requestId;

		private string userProjectName;

		private int? isUserProjectLogstoreExist;

		private int? isEtlMetaExist;

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

		public string UserProjectName
		{
			get
			{
				return userProjectName;
			}
			set	
			{
				userProjectName = value;
			}
		}

		public int? IsUserProjectLogstoreExist
		{
			get
			{
				return isUserProjectLogstoreExist;
			}
			set	
			{
				isUserProjectLogstoreExist = value;
			}
		}

		public int? IsEtlMetaExist
		{
			get
			{
				return isEtlMetaExist;
			}
			set	
			{
				isEtlMetaExist = value;
			}
		}
	}
}
