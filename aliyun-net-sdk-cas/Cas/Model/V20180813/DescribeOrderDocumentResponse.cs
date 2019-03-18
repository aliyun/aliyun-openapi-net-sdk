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

namespace Aliyun.Acs.cas.Model.V20180813
{
	public class DescribeOrderDocumentResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeOrderDocument_OrderDocument> orderDocumentList;

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

		public List<DescribeOrderDocument_OrderDocument> OrderDocumentList
		{
			get
			{
				return orderDocumentList;
			}
			set	
			{
				orderDocumentList = value;
			}
		}

		public class DescribeOrderDocument_OrderDocument
		{

			private int? documentType;

			private string tplDocNote;

			private string tplDocOssKey;

			private string orderDocOssKey;

			private long? orderDocDate;

			private string orderDocExt;

			public int? DocumentType
			{
				get
				{
					return documentType;
				}
				set	
				{
					documentType = value;
				}
			}

			public string TplDocNote
			{
				get
				{
					return tplDocNote;
				}
				set	
				{
					tplDocNote = value;
				}
			}

			public string TplDocOssKey
			{
				get
				{
					return tplDocOssKey;
				}
				set	
				{
					tplDocOssKey = value;
				}
			}

			public string OrderDocOssKey
			{
				get
				{
					return orderDocOssKey;
				}
				set	
				{
					orderDocOssKey = value;
				}
			}

			public long? OrderDocDate
			{
				get
				{
					return orderDocDate;
				}
				set	
				{
					orderDocDate = value;
				}
			}

			public string OrderDocExt
			{
				get
				{
					return orderDocExt;
				}
				set	
				{
					orderDocExt = value;
				}
			}
		}
	}
}
