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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeSagVbrRelationsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSagVbrRelations_SagVbrRelation> sagVbrRelations;

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

		public List<DescribeSagVbrRelations_SagVbrRelation> SagVbrRelations
		{
			get
			{
				return sagVbrRelations;
			}
			set	
			{
				sagVbrRelations = value;
			}
		}

		public class DescribeSagVbrRelations_SagVbrRelation
		{

			private string vbrInstanceId;

			private string sagInstanceId;

			private string sagUid;

			public string VbrInstanceId
			{
				get
				{
					return vbrInstanceId;
				}
				set	
				{
					vbrInstanceId = value;
				}
			}

			public string SagInstanceId
			{
				get
				{
					return sagInstanceId;
				}
				set	
				{
					sagInstanceId = value;
				}
			}

			public string SagUid
			{
				get
				{
					return sagUid;
				}
				set	
				{
					sagUid = value;
				}
			}
		}
	}
}
