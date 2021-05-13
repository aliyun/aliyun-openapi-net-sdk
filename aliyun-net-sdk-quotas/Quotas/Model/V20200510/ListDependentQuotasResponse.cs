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

namespace Aliyun.Acs.quotas.Model.V20200510
{
	public class ListDependentQuotasResponse : AcsResponse
	{

		private string requestId;

		private List<ListDependentQuotas_QuotasItem> quotas;

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

		public List<ListDependentQuotas_QuotasItem> Quotas
		{
			get
			{
				return quotas;
			}
			set	
			{
				quotas = value;
			}
		}

		public class ListDependentQuotas_QuotasItem
		{

			private string quotaActionCode;

			private string productCode;

			private float? scale;

			private List<ListDependentQuotas_DimensionsItem> dimensions;

			public string QuotaActionCode
			{
				get
				{
					return quotaActionCode;
				}
				set	
				{
					quotaActionCode = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public float? Scale
			{
				get
				{
					return scale;
				}
				set	
				{
					scale = value;
				}
			}

			public List<ListDependentQuotas_DimensionsItem> Dimensions
			{
				get
				{
					return dimensions;
				}
				set	
				{
					dimensions = value;
				}
			}

			public class ListDependentQuotas_DimensionsItem
			{

				private string dimensionKey;

				private List<string> dimensionValues;

				private List<string> dependentDimension;

				public string DimensionKey
				{
					get
					{
						return dimensionKey;
					}
					set	
					{
						dimensionKey = value;
					}
				}

				public List<string> DimensionValues
				{
					get
					{
						return dimensionValues;
					}
					set	
					{
						dimensionValues = value;
					}
				}

				public List<string> DependentDimension
				{
					get
					{
						return dependentDimension;
					}
					set	
					{
						dependentDimension = value;
					}
				}
			}
		}
	}
}
