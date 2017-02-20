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

namespace Aliyun.Acs.Iot.Model.V20160530
{
	public class CreateProductResponse : AcsResponse
	{
	    public bool? Success { get; set; }

	    public string ErrorMessage { get; set; }

	    public ProductInfo_ ProductInfo { get; set; }

	    public class ProductInfo_{
	        public string ProductKey { get; set; }

	        public string ProductName { get; set; }

	        public long? CatId { get; set; }

	        public long? CreateUserId { get; set; }

	        public string ProductDesc { get; set; }

	        public string FromSource { get; set; }

	        public string ExtProps { get; set; }

	        public string GmtCreate { get; set; }

	        public string GmtModified { get; set; }
	    }
	}
}