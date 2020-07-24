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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class UpdateProjectResponse : AcsResponse
	{

		private string requestId;

		private string project;

		private string createTime;

		private string modifyTime;

		private string serviceRole;

		private int? cU;

		private string type;

		private string regionId;

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

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
			}
		}

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public string ModifyTime
		{
			get
			{
				return modifyTime;
			}
			set	
			{
				modifyTime = value;
			}
		}

		public string ServiceRole
		{
			get
			{
				return serviceRole;
			}
			set	
			{
				serviceRole = value;
			}
		}

		public int? CU
		{
			get
			{
				return cU;
			}
			set	
			{
				cU = value;
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
			}
		}
	}
}
