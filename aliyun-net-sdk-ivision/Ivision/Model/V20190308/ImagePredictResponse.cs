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

namespace Aliyun.Acs.ivision.Model.V20190308
{
	public class ImagePredictResponse : AcsResponse
	{

		private string requestId;

		private ImagePredict_ImagePredict imagePredict;

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

		public ImagePredict_ImagePredict ImagePredict
		{
			get
			{
				return imagePredict;
			}
			set	
			{
				imagePredict = value;
			}
		}

		public class ImagePredict_ImagePredict
		{

			private string status;

			private string predictResult;

			private string predictId;

			private string predictTime;

			private string dataUrl;

			private string code;

			private string message;

			private string modelId;

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string PredictResult
			{
				get
				{
					return predictResult;
				}
				set	
				{
					predictResult = value;
				}
			}

			public string PredictId
			{
				get
				{
					return predictId;
				}
				set	
				{
					predictId = value;
				}
			}

			public string PredictTime
			{
				get
				{
					return predictTime;
				}
				set	
				{
					predictTime = value;
				}
			}

			public string DataUrl
			{
				get
				{
					return dataUrl;
				}
				set	
				{
					dataUrl = value;
				}
			}

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public string ModelId
			{
				get
				{
					return modelId;
				}
				set	
				{
					modelId = value;
				}
			}
		}
	}
}
