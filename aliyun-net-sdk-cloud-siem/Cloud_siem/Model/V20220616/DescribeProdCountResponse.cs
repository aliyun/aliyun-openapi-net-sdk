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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class DescribeProdCountResponse : AcsResponse
	{

		private string requestId;

		private DescribeProdCount_Data data;

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

		public DescribeProdCount_Data Data
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

		public class DescribeProdCount_Data
		{

			private int? aliyunProdCount;

			private int? hcloudProdCount;

			private int? qcloudProdCount;

			private int? idcProdCount;

			private int? aliyunImportedCount;

			private int? hcloudImportedCount;

			private int? qcloudImportedCount;

			private int? idcImportedCount;

			public int? AliyunProdCount
			{
				get
				{
					return aliyunProdCount;
				}
				set	
				{
					aliyunProdCount = value;
				}
			}

			public int? HcloudProdCount
			{
				get
				{
					return hcloudProdCount;
				}
				set	
				{
					hcloudProdCount = value;
				}
			}

			public int? QcloudProdCount
			{
				get
				{
					return qcloudProdCount;
				}
				set	
				{
					qcloudProdCount = value;
				}
			}

			public int? IdcProdCount
			{
				get
				{
					return idcProdCount;
				}
				set	
				{
					idcProdCount = value;
				}
			}

			public int? AliyunImportedCount
			{
				get
				{
					return aliyunImportedCount;
				}
				set	
				{
					aliyunImportedCount = value;
				}
			}

			public int? HcloudImportedCount
			{
				get
				{
					return hcloudImportedCount;
				}
				set	
				{
					hcloudImportedCount = value;
				}
			}

			public int? QcloudImportedCount
			{
				get
				{
					return qcloudImportedCount;
				}
				set	
				{
					qcloudImportedCount = value;
				}
			}

			public int? IdcImportedCount
			{
				get
				{
					return idcImportedCount;
				}
				set	
				{
					idcImportedCount = value;
				}
			}
		}
	}
}
