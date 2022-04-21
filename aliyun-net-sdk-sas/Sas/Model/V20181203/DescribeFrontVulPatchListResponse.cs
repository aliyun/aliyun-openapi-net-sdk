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
	public class DescribeFrontVulPatchListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeFrontVulPatchList_FrontPatch> frontPatchList;

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

		public List<DescribeFrontVulPatchList_FrontPatch> FrontPatchList
		{
			get
			{
				return frontPatchList;
			}
			set	
			{
				frontPatchList = value;
			}
		}

		public class DescribeFrontVulPatchList_FrontPatch
		{

			private string uuid;

			private List<DescribeFrontVulPatchList_Patch> patchList;

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

			public List<DescribeFrontVulPatchList_Patch> PatchList
			{
				get
				{
					return patchList;
				}
				set	
				{
					patchList = value;
				}
			}

			public class DescribeFrontVulPatchList_Patch
			{

				private string name;

				private string aliasName;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string AliasName
				{
					get
					{
						return aliasName;
					}
					set	
					{
						aliasName = value;
					}
				}
			}
		}
	}
}
